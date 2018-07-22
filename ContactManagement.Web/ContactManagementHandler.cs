using ContagiousCode.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace ContactManagement.Web
{
    public class ContactManagementHandler : Handler, IHttpHandler, IRequiresSessionState
    {
        bool IHttpHandler.IsReusable
        {
            get
            {
                return true;
            }
        }

        void IHttpHandler.ProcessRequest(HttpContext context)
        {
            Setup(context);

            switch (this.Method)
            {
                //case "GetArtists":
                //    GetArtists();
                //    break;

                //case "GetAlbums":
                //    GetAlbums();
                //    break;
            }

            ReturnData();
        }

        //private void GetArtists()
        //{
        //    string template = Music.Web.Utility.GetHtml("ArtistMain.htm");
        //    string html = "";

        //    List<Artist> artistList = new List<Artist>();
        //    Provider provider = new Provider();
        //    artistList = provider.ArtistSelect();

        //    for (int i = 0; i < artistList.Count; i++)
        //    {
        //        html += template.Replace("$ARTIST$", artistList[i].Name)
        //                        .Replace("$ARTISTID$", artistList[i].ArtistID.ToString())
        //                    ;
        //    }

        //    this.AjaxJson.Data = html;
        //}

        //private void GetAlbums()
        //{
        //    int artistID = this.GetQueryFormValue("ArtistID", 0);
        //    string template = Music.Web.Utility.GetHtml("AlbumMain.htm");
        //    string html = "";

        //    List<Album> albumList = new List<Album>();
        //    Provider provider = new Provider();
        //    albumList = provider.AlbumSelectByArtistID(artistID);

        //    for (int i = 0; i < albumList.Count; i++)
        //    {
        //        html += template.Replace("$ALBUM$", albumList[i].Name)
        //                        .Replace("$ALBUMID$", albumList[i].AlbumID.ToString())
        //                    ;
        //    }

        //    this.AjaxJson.Data = html;
        //}







    }
}
