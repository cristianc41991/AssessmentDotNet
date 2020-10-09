using System;
using System.Collections.Generic;
using System.Text;

namespace AssessmentDotNet2020.Shared.Entities
{
  public  class ColaPeople
    {
        public int ColaId { get; set; }
        public int PeopleId { get; set; }
        public Cola Cola { get; set; }
        public People People { get; set; }
        public int status { get; set; }
        public int position { get; set; }
    }
}
