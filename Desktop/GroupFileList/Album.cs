using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CorboLibUtils.Dominio;

namespace GroupFileList.Model
{
    public class Album : ClasseBase
    {
        List<Music> _musicList;

        public String name { get; set; }
        public String path { get; set; }
        public List<Music> musicList 
        { 
            get
            {
                return _musicList;
            }
            set
            {
                _musicList = value;
            } 
        }
        public Album()
        {
            _musicList = new List<Music>();
        }
    }
}
