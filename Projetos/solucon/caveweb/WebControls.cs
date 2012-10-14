using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solucon.WebControls
{
    public class WebFormat
    {
        public static void addItemDefault(System.Web.UI.WebControls.DropDownList dropdownList,
            System.Web.UI.WebControls.ListItem item)
        {
            foreach (System.Web.UI.WebControls.ListItem i in dropdownList.Items)
            {
                i.Selected = false;
            }
            item.Selected = true;
            dropdownList.Items.Add(item);
        }

    }
}
