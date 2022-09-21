using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Parsers
{
    public abstract class ParserBase
    {
        public Product ParsedProduct { get; protected set; }
        private HttpResponseMessage response;

        protected ParserBase(HttpResponseMessage message)
        {
            this.response = message;
        }

        public abstract void Parse();
    }
}
