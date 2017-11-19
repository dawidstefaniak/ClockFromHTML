using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ClockFromHTML
{
    class HTMLString
    {

    public StreamReader ReadHTMLStream(string urlAddress)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader sr = null;
                if (response.CharacterSet != null)
                {
                    sr = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }
                return sr;
            }
            else return null;
        }
    }
}
