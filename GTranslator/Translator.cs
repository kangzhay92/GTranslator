using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace GTranslator
{
    /// <summary>
    /// Translate text using Google's online languange tools.
    /// </summary>
    class Translator
    {
        #region Public Properties
        
        /// <summary>
        /// Gets the supported languages.
        /// </summary>
        public static IEnumerable<string> Languages
        {
            get
            {
                InitializeLanguages();
                return languageMap.Keys.OrderBy(p => p);
            }
        }

        /// <summary>
        /// Gets the time taken to perform the translation.
        /// </summary>
        public TimeSpan TranslationTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the URL used to speak the translation.
        /// </summary>
        public string TranslationSpeechURL
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        public Exception Error
        {
            get;
            private set;
        }

        #endregion

        #region Public Methods

        public string Translate(string sourceText, string sourceLanguage, string targetLanguage)
        {
            // initialize
            Error = null;
            TranslationSpeechURL = null;
            TranslationTime = TimeSpan.Zero;

            DateTime tmStart = DateTime.Now;
            string translation = string.Empty;

            try
            {
                // download translation
                string url = string.Format(
                    "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                    LanguageToIdentifier(sourceLanguage),
                    LanguageToIdentifier(targetLanguage),
                    HttpUtility.UrlEncode(sourceText));

                string outFile = Path.GetTempFileName();

                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add(
                        "user-agent",
                        "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
                    wc.DownloadFile(url, outFile);
                }

                // get translated text
                if (File.Exists(outFile))
                {
                    // get phrase collection
                    string text = File.ReadAllText(outFile);
                    int index = text.IndexOf(string.Format(",,\"{0}\"", LanguageToIdentifier(sourceLanguage)));
                    if (index == -1)
                    {
                        // translation of single word
                        int startQuote = text.IndexOf('\"');
                        if (startQuote != -1)
                        {
                            int endQuote = text.IndexOf('\"', startQuote + 1);
                            if (endQuote != -1)
                            {
                                translation = text.Substring(startQuote + 1, endQuote - startQuote - 1);
                            }
                        }
                    }
                    else
                    {
                        // translation of phrase
                        text = text.Substring(0, index);
                        text = text.Replace("],[", ",");
                        text = text.Replace("]", string.Empty);
                        text = text.Replace("[", string.Empty);
                        text = text.Replace("\",\"", "\"");

                        // get translated phrases
                        string[] phrases = text.Split(new[] { '\"' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; (i < phrases.Count()); i += 2)
                        {
                            string translatedPhrase = phrases[i];
                            if (translatedPhrase.StartsWith(",,"))
                            {
                                i--;
                                continue;
                            }
                            translation += translatedPhrase + "  ";
                        }
                    }

                    // fix up translation
                    translation = translation.Trim();
                    translation = translation.Replace(" ?", "?");
                    translation = translation.Replace(" !", "!");
                    translation = translation.Replace(" ,", ",");
                    translation = translation.Replace(" .", ".");
                    translation = translation.Replace(" ;", ";");

                    // and translation speech URL
                    TranslationSpeechURL = string.Format(
                        "https://translate.googleapis.com/translate_tts?ie=UTF-8&q={0}&tl={1}&total=1&idx=0&textlen={2}&client=gtx",
                        HttpUtility.UrlEncode(translation),
                        LanguageToIdentifier(targetLanguage),
                        translation.Length);
                }
            }
            catch (Exception ex)
            {
                Error = ex;
            }

            // Return result
            TranslationTime = DateTime.Now - tmStart;
            return translation;
        }

        #endregion

        /// <summary>
        /// Converts a language to its language id.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <returns>Language id or empty if none.</returns>
        private static string LanguageToIdentifier(string language)
        {
            string id = string.Empty;

            InitializeLanguages();
            languageMap.TryGetValue(language, out id);

            return id;
        }

        /// <summary>
        /// Initialize the languages that will be used by the translator
        /// </summary>
        private static void InitializeLanguages()
        {
            if (languageMap == null)
            {
                languageMap = new Dictionary<string, string>();

                languageMap.Add("Afrikaans", "af");
                languageMap.Add("Albanian", "sq");
                languageMap.Add("Amharic", "am");
                languageMap.Add("Arabic", "ar");
                languageMap.Add("Armenian", "hy");
                languageMap.Add("Azerbaijani", "az");
                languageMap.Add("Basque", "eu");
                languageMap.Add("Belarusian", "be");
                languageMap.Add("Bengali", "bn");
                languageMap.Add("Bosnian", "bs");
                languageMap.Add("Bulgarian", "bg");
                languageMap.Add("Catalan", "ca");
                languageMap.Add("Cebuano", "ceb");
                languageMap.Add("Chichewa", "ny");
                languageMap.Add("Chinese", "zh-CN");
                languageMap.Add("Corsican", "co");
                languageMap.Add("Croatian", "hr");
                languageMap.Add("Czech", "cs");
                languageMap.Add("Danish", "da");
                languageMap.Add("Dutch", "nl");
                languageMap.Add("English", "en");
                languageMap.Add("Esperanto", "eo");
                languageMap.Add("Estonian", "et");
                languageMap.Add("Filipino", "tl");
                languageMap.Add("Finnish", "fi");
                languageMap.Add("French", "fr");
                languageMap.Add("Frisian", "fy");
                languageMap.Add("Galician", "gl");
                languageMap.Add("Georgian", "ka");
                languageMap.Add("German", "de");
                languageMap.Add("Greek", "el");
                languageMap.Add("Gujarati", "gu");
                languageMap.Add("Haitian Creole", "ht");
                languageMap.Add("Hausa", "ha");
                languageMap.Add("Hawaiian", "haw");
                languageMap.Add("Hebrew", "iw");
                languageMap.Add("Hindi", "hi");
                languageMap.Add("Hmong", "hmn");
                languageMap.Add("Hungarian", "hu");
                languageMap.Add("Icelandic", "is");
                languageMap.Add("Igbo", "ig");
                languageMap.Add("Indonesian", "id");
                languageMap.Add("Irish", "ga");
                languageMap.Add("Italian", "it");
                languageMap.Add("Japanese", "ja");
                languageMap.Add("Javanese", "jw");
                languageMap.Add("Kannada", "kn");
                languageMap.Add("Kazakh", "kk");
                languageMap.Add("Khmer", "km");
                languageMap.Add("Korean", "ko");
                languageMap.Add("Kurdish", "ku");
                languageMap.Add("Kyrgyz", "ky");
                languageMap.Add("Lao", "lo");
                languageMap.Add("Latin", "la");
                languageMap.Add("Latvian", "lv");
                languageMap.Add("Lithuanian", "lt");
                languageMap.Add("Luxembourgish", "lb");
                languageMap.Add("Macedonian", "mk");
                languageMap.Add("Malagasy", "mg");
                languageMap.Add("Malay", "ms");
                languageMap.Add("Malayalam", "ml");
                languageMap.Add("Maltese", "mt");
                languageMap.Add("Maori", "mi");
                languageMap.Add("Marathi", "mr");
                languageMap.Add("Mongolian", "mn");
                languageMap.Add("Myanmar", "my");
                languageMap.Add("Nepali", "ne");
                languageMap.Add("Norwegian", "no");
                languageMap.Add("Pashto", "ps");
                languageMap.Add("Persian", "fa");
                languageMap.Add("Polish", "pl");
                languageMap.Add("Portuguese", "pt");
                languageMap.Add("Punjabi", "ma");
                languageMap.Add("Romanian", "ro");
                languageMap.Add("Russian", "ru");
                languageMap.Add("Samoan", "sm");
                languageMap.Add("Scots Gaelic", "gd");
                languageMap.Add("Serbian", "sr");
                languageMap.Add("Sesotho", "st");
                languageMap.Add("Shona", "sn");
                languageMap.Add("Sindhi", "sd");
                languageMap.Add("Sinhala", "si");
                languageMap.Add("Slovak", "sk");
                languageMap.Add("Slovenian", "sl");
                languageMap.Add("Somali", "so");
                languageMap.Add("Spanish", "es");
                languageMap.Add("Sundanese", "su");
                languageMap.Add("Swahili", "sw");
                languageMap.Add("Swedish", "sv");
                languageMap.Add("Tajik", "tg");
                languageMap.Add("Tamil", "ta");
                languageMap.Add("Telugu", "te");
                languageMap.Add("Thai", "th");
                languageMap.Add("Turkish", "tr");
                languageMap.Add("Ukrainian", "uk");
                languageMap.Add("Urdu", "ur");
                languageMap.Add("Uzbek", "uz");
                languageMap.Add("Vietnamese", "vi");
                languageMap.Add("Welsh", "cy");
                languageMap.Add("Xhosa", "xh");
                languageMap.Add("Yiddish", "yi");
                languageMap.Add("Yoruba", "yo");
                languageMap.Add("Zulu", "zu");
            }
        }

        /// <summary>
        /// Languages to translation mode.
        /// </summary>
        private static Dictionary<string, string> languageMap;
    }
}
