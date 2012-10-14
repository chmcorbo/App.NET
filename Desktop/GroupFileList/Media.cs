using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CorboLibUtils.Dominio;

namespace GroupFileList.Model
{
    public class Media : ClasseBase
    {
        List<Artist> _artistList;

        public String name { get; set; }
        public String description { get; set; }
        public List<Artist> artistList
        {
            get
            {
                return _artistList;
            }
            set
            {
                _artistList = value;
            }
        }
        public Media()
        {
            _artistList = new List<Artist>();
        }
    }
}
