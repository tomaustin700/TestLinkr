using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinkr
{
    public class TestLinkr : Attribute
    {
        private readonly int _tfsId1;
        private readonly int _tfsId2;
        private readonly int _tfsId3;
        private readonly int _tfsId4;
        private readonly int _tfsId5;


        public TestLinkr(int tfsId)
        {
            _tfsId1 = tfsId;
        }

        public TestLinkr(int tfsId1, int tfsId2)
        {
            _tfsId1 = tfsId1;
            _tfsId2 = tfsId2;
        }

        public TestLinkr(int tfsId1, int tfsId2, int tfsId3)
        {
            _tfsId1 = tfsId1;
            _tfsId2 = tfsId2;
            _tfsId3 = tfsId3;
        }

        public TestLinkr(int tfsId1, int tfsId2, int tfsId3, int tfsId4)
        {
            _tfsId1 = tfsId1;
            _tfsId2 = tfsId2;
            _tfsId3 = tfsId3;
            _tfsId4 = tfsId4;
        }

        public TestLinkr(int tfsId1, int tfsId2, int tfsId3, int tfsId4, int tfsId5)
        {
            _tfsId1 = tfsId1;
            _tfsId2 = tfsId2;
            _tfsId3 = tfsId3;
            _tfsId4 = tfsId4;
            _tfsId5 = tfsId5;
        }


    }

   
}
