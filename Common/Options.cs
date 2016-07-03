﻿namespace Strike
{
    public class Options
    {
        /// <summary>
        /// Enable GitHub flavored markdown.
        /// https://github.com/chjj/marked#gfm
        /// </summary>
        public bool GitHubFlavor = true;

        /// <summary>
        /// https://github.com/chjj/marked#tables
        /// Enable GFM tables. This option requires the gfm option to be true.
        /// </summary>
        public bool Tables = true;

        /// <summary>
        /// Enable GFM line breaks. This option requires the gfm option to be true.
        /// https://github.com/chjj/marked#breaks
        /// </summary>
        public bool Breaks;

        /// <summary>
        /// Conform to obscure parts of markdown.pl as much as possible. Don't fix any of the original markdown bugs or poor behavior.
        /// https://github.com/chjj/marked#pedantic
        /// </summary>
        public bool Pedantic;

        /// <summary>
        /// Sanitize the output. Ignore any HTML that has been input.
        /// Default: false
        /// https://github.com/chjj/marked#sanitize
        /// </summary>
        public bool Sanitize;

        /// <summary>
        /// Use smarter list behavior than the original markdown.
        /// Default: true
        /// https://github.com/chjj/marked#smartlists
        /// </summary>
        public bool SmartLists = true;

        /// <summary>
        /// Use "smart" typograhic punctuation for things like quotes and dashes.
        /// Default: false
        /// https://github.com/chjj/marked#smartypants
        /// </summary>
        public bool SmartyPants;

        /// <summary>
        /// Use "Xhtml" rendering.
        /// Default: false
        /// https://github.com/chjj/marked#xhtml
        /// </summary>
        public bool Xhtml;

        /// <summary>
        /// A function to highlight code blocks.
        /// https://github.com/chjj/marked#highlight
        /// Default: "function (code) {return code;}"
        /// </summary>
        public string Highlight = "function (code) {return code;}";

        public string GetOptionsJs()
        {
            return $@"
{{
    gfm: {GitHubFlavor.AsJs()},
    tables: {Tables.AsJs()},
    breaks: {Breaks.AsJs()},
    sanitize: {Sanitize.AsJs()},
    smartLists: {SmartLists.AsJs()},
    pedantic: {Pedantic.AsJs()},
    smartypants: {SmartyPants.AsJs()},
    highlight: {Highlight},
    xhtml: {Xhtml.AsJs()},
    renderer: renderer
}}";
        }

    }
}