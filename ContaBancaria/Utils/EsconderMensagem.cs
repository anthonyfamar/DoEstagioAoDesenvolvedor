using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ContaBancaria.Models
{
    public static class EsconderMensagem
    {
        public static void RegistrarScriptOcultarMensagem(Page page, string clientId)
        {
            string script = $@"
                setTimeout(function () {{
                    var msg = document.getElementById('{clientId}');
                    if (msg) {{
                        msg.style.transition = 'opacity 1s';
                        msg.style.opacity = 0;
                        setTimeout(function () {{
                            msg.style.display = 'none';
                        }}, 1000);
                    }}
                }}, 5000);";

            page.ClientScript.RegisterStartupScript(page.GetType(), "HideMessage", script, true);
        }
    }
}