using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Parsers
{
    public class AhParser : ParserBase
    {
        public AhParser(HttpResponseMessage message) : base(message)
        {

        }
        public override void Parse()
        {
            throw new NotImplementedException();
        }
    }
}
