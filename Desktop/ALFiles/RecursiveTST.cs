using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ALFiles.GroupFileList
{
    public class RecursiveTST
    {
        public void ConcatenaStr(Int32 pT)
        {
            Int32 t;

            if (pT < 5)
            {
                t = pT;
                t++;
                ConcatenaStr(t);
            }

        }
        public void LimparPasta(DirectoryInfo pasta)
        {
            // Obtém as subspastas da pasta atual
            var subpastas = pasta.GetDirectories();

            // Percorre a lista de subpastas
            foreach (var p in subpastas)
            {
                // Obtém a lista de arquivos dessa subpasta
                var arquivos = p.GetFiles();

                // Percorre a lista de arquivos da subpasta
                foreach (var a in arquivos)
                {
                    // O arquivo está marcado como ReadOnly?
                    if ((a.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        // Sim! Então remove esse atributo...
                        a.Attributes ^= FileAttributes.ReadOnly;
                    }

                    // Apaga o arquivo
                    a.Delete();
                }

                // Limpa as subpastas da subpasta atual
                LimparPasta(p);

                // A subpasta está marcada como ReadOnly?
                if ((p.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    // Sim! Então remove esse atributo...
                    p.Attributes ^= FileAttributes.ReadOnly;
                }

                // Finalmente, apaga a subpasta
                p.Delete();
            }
        }


    }
}
