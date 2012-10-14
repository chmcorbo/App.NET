using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GroupFileList.Model
{
    public class FitterMedia
    {
        private String _name = String.Empty;
        private String _oldname = String.Empty;
        private Media _media;

        public Media MountMedia(String pDescription, String pPath)
        {
            _media = new Media();
            DriveInfo driveInfo = new DriveInfo(pPath);

            _media.name = driveInfo.VolumeLabel;
            _media.description = pDescription;
            DirectoryInfo folderMedia = new DirectoryInfo(pPath);

            // Enviando pasta da Media porque dentro dela deverá ter as pastas dos artistas.
            _media.artistList=MountArtistList(folderMedia);
            return _media;
        }
        
        public List<Artist> MountArtistList(DirectoryInfo pFolderMedia)
        {
            List<Artist> artistList = new List<Artist>();
            Artist artist;

            /* 
             * Verificando se a pasta da Media tem subpastas
             * Se não tiver subpasta(s) significa que não existem artistas.
             * Se tiver subpasta(s) então entrará na condição para criar um objeto para cada artista;
             * 
             */
            if (pFolderMedia.GetDirectories().Length > 0)
            {
                DirectoryInfo[] foldersArtist = pFolderMedia.GetDirectories();

                foreach (DirectoryInfo folderArtist in foldersArtist)
                {
                    artist = new Artist();
                    artist.name = folderArtist.Name;
                    artist.path = folderArtist.Parent.Name;
                    artist.albumList = MountAlbumList(folderArtist);
                    artistList.Add(artist);
                }
            }
            else
            {
                artist = new Artist();
                artist.name = "Artista desconhecido";
                artist.path = pFolderMedia.Name;
                artist.albumList = MountAlbumList(pFolderMedia);
                artistList.Add(artist);
            }

            return artistList;
        }

        public List<Album> MountAlbumList(DirectoryInfo pFolderArtist)
        {
            Album album;
            List<Album> albumList = new List<Album>();
            /* 
             * Verificando se dentro da pasta do artista tem alguma subpasta;
             * Se não tiver, significa que será criado um Album caracterizado como desconhecido
             * Se tiver subpasta, então montará a lista de albuns.
             * 
             */
            if (pFolderArtist.GetDirectories().Length > 0)
            {
                DirectoryInfo[] foldersAlbum = pFolderArtist.GetDirectories();
                foreach (DirectoryInfo folderAlbum in foldersAlbum)
                {
                    _name = String.Empty;
                    _oldname = String.Empty;
                    MountAlbum(albumList, folderAlbum);
                }
            }
            else
            {
                /*
                 * Entrará aqui somente se não existir nenhum subpasta referente ao album
                 */ 
                album = new Album();
                album.name = pFolderArtist.Name;
                album.path = pFolderArtist.Parent.Name;
                album.musicList=MountListMusic(pFolderArtist);
                albumList.Add(album);
            }
            return albumList;
        }

        public void MountAlbum(List<Album> pAlbumList, DirectoryInfo pFolderAlbum)
        {
            Album _album;
            if (pFolderAlbum.GetDirectories().Length > 0)
            {
                var subPastas = pFolderAlbum.GetDirectories();
                foreach (DirectoryInfo subpasta in subPastas)
                {
                    if (_name == String.Empty)
                        _name = subpasta.Parent + " / " + subpasta.Name;
                    else
                        _name = _name + " / " + subpasta.Name;
                    MountAlbum(pAlbumList, subpasta);
                }
            }
            else
            {
                /* 
                 * Entrará aqui se só tiver um nível de pasta de album ou 
                 * não for encontrado mais nenhum nivel;
                 */
                _album = new Album();

                if (_name == String.Empty)
                    _album.name = pFolderAlbum.Name;
                else
                    _album.name = _name;
                    
                _album.path = pFolderAlbum.Parent.Name;
                _album.musicList = MountListMusic(pFolderAlbum);
                pAlbumList.Add(_album);
                _name = _oldname;
            }
        }

        public List<Music> MountListMusic(DirectoryInfo pPasta)
        {
            List<Music> _musicas = new List<Music>();
            // lixo técnico
            // Código para contagem de objetos;
            // var teste = pPasta.GetFiles().Count(p => p.Extension == ".wma" && p.Extension == ".mp3");
            
            Music music;
            Int16 vOrd;

            var fileList = from file in pPasta.GetFiles()
                           where file.Extension == ".mp3" || file.Extension == ".wma"
                           select file;
            vOrd=1;

            foreach (FileInfo f in fileList)
            {
                music = new Music();
                music.ord = vOrd;
                music.name = f.Name;
                vOrd++;
                _musicas.Add(music);
            }
            return _musicas;
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


        //Agora é só obter uma referência para a pasta, e chamar o método:
        public void HoraDeApagarAsPastas()
        {
            // Obtém uma referência para a pasta que queremos deixar vazia
            var pasta = new DirectoryInfo(@"C:\NomeDaPasta");

            // Apaga todas as subpastas e arquivos, mesmo que estejam ReadOnly
            LimparPasta(pasta);
        }

    }
}
