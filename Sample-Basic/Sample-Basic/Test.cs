using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic
{
    public  class Test
    {
        public string DepName { get; set; }
        private int id { get; set; }

        protected string code { get; set; }

        public int coundnumber()
        {
            id = 2;
            return id;
        }
    }
}
