using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CorboLibUtils.Dominio;

namespace GroupFileList.Model
{
    public class Artist : ClasseBase
    {
        List<Album> _albumList;

        public String name { get; set; }
        public String path { get; set; }
        public List<Album> albumList
        {
            get
            {
                return _albumList;
            }
            set
            {
                _albumList = value;
            }
        }
        public Artist()
        {
            _albumList = new List<Album>();
        }
    }
}
