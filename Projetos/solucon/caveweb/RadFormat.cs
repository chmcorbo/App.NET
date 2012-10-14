using System;
using Telerik.Web.UI;

namespace Solucon.RadControls
{
    public static class WebControlFormat
    {
        public static void addItemDefault(ref System.Web.UI.WebControls.DropDownList dropdownList,
            System.Web.UI.WebControls.ListItem item)
        {
            foreach (System.Web.UI.WebControls.ListItem i in dropdownList.Items)
            {
                i.Selected = false;
            }
            dropdownList.Items.Add(item);
        }
    
    }

    public static class RadFormat
    {
        public static void formatarGrid(RadGrid grid)
        {
            grid.PagerStyle.PagerTextFormat = "Mudar página: {4} &nbsp;Exibindo página {0} de {1}, itens {2} até {3} de {5}.";
            grid.PagerStyle.NextPagesToolTip = "Próximas paginas";
            grid.PagerStyle.NextPageToolTip = "Próxima pagina";
            grid.PagerStyle.PrevPagesToolTip = "Páginas anteriores";
            grid.PagerStyle.PrevPageToolTip = "Página anterior";
            grid.PagerStyle.NextPageText = "Próxima";
            grid.PagerStyle.PrevPageText = "Anterior";
            grid.SortingSettings.SortToolTip = "Clique aqui para organizar";
            grid.MasterTableView.NoMasterRecordsText = "Nenhum registro encontrado.";
            grid.PagerStyle.Mode = GridPagerMode.NextPrevAndNumeric;
        }
        public static void itemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item.ItemType == Telerik.Web.UI.GridItemType.Item ||
                e.Item.ItemType == Telerik.Web.UI.GridItemType.AlternatingItem)
            {
                e.Item.Style["cursor"] = "hand"; //' Cursor
            }
        }

        public static void itemDataBound(object sender, GridItemEventArgs e, String urllink, String uniqueName)
        {
            Telerik.Web.UI.GridDataItem item;
            if (e.Item.ItemType == Telerik.Web.UI.GridItemType.Item ||
                e.Item.ItemType == Telerik.Web.UI.GridItemType.AlternatingItem)
            {
                e.Item.Attributes.Add("onmouseover", "this.style.backgroundColor='" + "#E0E0E0" + "'");

                if (e.Item.ItemType == Telerik.Web.UI.GridItemType.AlternatingItem)
                    e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor='" + "#F7F7F7" + "'");
                else
                    e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor='" + "white" + "'");

                item = e.Item as Telerik.Web.UI.GridDataItem;

                e.Item.Attributes.Add("onclick", "javascript:location.href='" + urllink + item[uniqueName].Text.Trim() + "';");

                e.Item.Style["cursor"] = "hand"; //' Cursor
            }
        }
    }
}
