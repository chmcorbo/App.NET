namespace GroupFileList.DAO
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    using GroupFileList.Model;
    using System.Collections.Generic;
    using CorboLibUtils.DataHora;
    using CorboLibUtils.DAO;
    using CorboLibUtils.Dominio;

    public class DAOMedia : DAOBase
    {
        private XDocument _xmlDoc;
        private String _caminho;
        private Boolean _erro = false;

        public DAOMedia(String pCaminho)
        {
            _caminho = pCaminho;
            _xmlDoc = XDocument.Load(_caminho);
        }

        private void salvarXML()
        {
            _xmlDoc.Save(_caminho);
        }

        public override bool alterar(CorboLibUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool buscarID(CorboLibUtils.Dominio.ClasseBase obj)
        {
            throw new NotImplementedException();
        }

        public override bool excluir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            _erro = false;
            try
            {
                var xmlMedia = _xmlDoc.Descendants("media").Where(x => x.Attribute("name").Value == ((Media)obj).name.ToString()).FirstOrDefault();
                if (xmlMedia != null)
                {
                    xmlMedia.Remove();
                    salvarXML();
                }
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao excluir a mídia. " + e.Message);
            }
            return !_erro;

        }

        public override bool inserir(CorboLibUtils.Dominio.ClasseBase obj)
        {
            _erro = false;

            try
            {

                XElement _newMedia = new XElement("media");
                _newMedia.SetAttributeValue("name", ((Media)obj).name);
                _newMedia.SetAttributeValue("description", ((Media)obj).description);

                foreach (Artist artist in ((Media)obj).artistList)
                {
                    XElement _newArtist = new XElement("artist");
                    _newArtist.SetAttributeValue("name", artist.name);
                    _newArtist.SetAttributeValue("path", artist.path);
                        
                    foreach (Album album in artist.albumList)
                    {
                        XElement _newAlbum = new XElement("album");
                        _newAlbum.SetAttributeValue("name", album.name);
                        _newAlbum.SetAttributeValue("path", album.path);

                        foreach (Music music in album.musicList)
                        {
                            XElement _newMusic = new XElement("music");
                            _newMusic.SetAttributeValue("ord", music.ord);
                            _newMusic.SetAttributeValue("name", music.name);
                            _newAlbum.Add(_newMusic);
                        }
                        _newArtist.Add(_newAlbum);
                    }
                    _newMedia.Add(_newArtist);
                }

                _xmlDoc.Element("various_media").Add(_newMedia);
                salvarXML();
            }
            catch (Exception e)
            {
                _erro = true;
                throw new Exception("Erro ao inserir media. " + e.Message);
            }

            return !_erro;
        }

        private Music carregaObjMusica(XElement _pXML_music)
        {
            Music music = new Music();

            music.ord = Convert.ToInt32(_pXML_music.Attribute("ord").Value);
            music.name = _pXML_music.Attribute("name").Value;

            return music;
        }


        private Album carregaObjAlbum(XElement _pXML_album)
        {
            Album album = new Album();

            album.path = _pXML_album.Attribute("path").Value;
            album.name = _pXML_album.Attribute("name").Value;

            return album;
        }

        private Artist carregaObjArtista(XElement _pXML_artist)
        {
            Artist artist = new Artist();

            artist.path = _pXML_artist.Attribute("path").Value;
            artist.name = _pXML_artist.Attribute("name").Value;

            return artist;
        }

        private Media carregaObjMedia(XElement _pXML_media)
        {
            Media media = new Media();

            media.name = _pXML_media.Attribute("name").Value;
            media.description = _pXML_media.Attribute("description").Value;

            return media;
        }

        public List<Media> listaMedia()
        {
            List<Media> lstMedia = new List<Media>();
            Media media;

            XElement _arquivo = XElement.Load(_caminho);

            var xml_lst_media = _arquivo.Descendants("media");

            foreach (XElement xml_media in xml_lst_media)
            {
                media = new Media();
                media.name = xml_media.Attribute("name").Value;
                media.description = xml_media.Attribute("description").Value;
                lstMedia.Add(media);
            }

            return lstMedia;
        }

        public List<Artist> listaArtista(Media pMedia)
        {
            List<Artist> lstArtist = new List<Artist>();
            Artist artist;

            XElement _arquivo = XElement.Load(_caminho);

            var xml_media = _arquivo.Descendants("media").Where(m => m.Attribute("name").Value.ToUpper() == pMedia.name.ToUpper()).FirstOrDefault();

            if (xml_media != null)
            {

                var xml_lst_artist = xml_media.Descendants("artist");

                foreach (XElement xml_artist in xml_lst_artist)
                {
                    artist = new Artist();
                    artist.name = xml_artist.Attribute("name").Value;
                    artist.path = xml_artist.Attribute("path").Value;
                    lstArtist.Add(artist);
                }
            }
            return lstArtist;
        }

        public List<Album> listaAlbum(Artist pArtist)
        {
            List<Album> lstAlbum = new List<Album>();
            Album album;
            
            XElement _arquivo = XElement.Load(_caminho);

            var xml_artist = _arquivo.Descendants("artist").Where(m => m.Attribute("name").Value.ToUpper() == pArtist.name.ToUpper()).FirstOrDefault();

            if (xml_artist != null)
            {
                var xml_lst_album = xml_artist.Descendants("album");

                foreach (XElement xml_album in xml_lst_album)
                {
                    album = new Album();
                    album.name = xml_album.Attribute("name").Value;
                    album.path = xml_album.Attribute("path").Value;
                    lstAlbum.Add(album);
                }
            }
            return lstAlbum;
        }

        public List<Music> listaMusica(Album pAlbum)
        {
            List<Music> lstMusic = new List<Music>();
            Music music;

            XElement _arquivo = XElement.Load(_caminho);

            var xml_album = _arquivo.Descendants("album").Where(m => m.Attribute("name").Value.ToUpper() == pAlbum.name.ToUpper()).FirstOrDefault();

            if (xml_album != null)
            {
                var xml_lst_music = xml_album.Descendants("music");

                foreach (XElement xml_music in xml_lst_music)
                {
                    music = new Music();
                    music.name = xml_music.Attribute("name").Value;
                    music.ord = Convert.ToInt32(xml_music.Attribute("ord").Value);
                    lstMusic.Add(music);
                }
            }
            return lstMusic;
        }

        public List<Media> localizaMusica(String pNomeMusica)
        {
            List<Media> lstMedia = new List<Media>();
            Music music;
            Album album;
            Artist artist;
            Media media;

            XElement _arquivo = XElement.Load(_caminho);

            var xml_musics = _arquivo.Descendants("music").Where(x => x.Attribute("name").Value.ToUpper().Contains(pNomeMusica.ToUpper()));

            if (xml_musics != null)
            {
                foreach (XElement _xml_music in xml_musics)
                {
                    var _xml_albuns = _xml_music.Ancestors("album");
                    foreach (XElement _xml_album in _xml_albuns)
                    {
                        var _xml_artists = _xml_album.Ancestors("artist");
                        foreach (XElement _xml_artist in _xml_artists)
                        {
                            var _xml_varios_media = _xml_artist.Ancestors("media");

                            foreach (XElement _xml_media in _xml_varios_media)
                            {
                                media = lstMedia.Where(m => m.name == _xml_media.Attribute("name").Value).FirstOrDefault();

                                /* var various_media = from m in lstMedia
                                                    where m.name == _xml_media.Attribute("name").Value
                                                    select m;
                                 */

                                if (media == null)
                                {
                                    /* Passo 1
                                     *      Defina os atributos de media;
                                     *      Defina os atributos de artist;
                                     *      Defina os atributos de album;
                                     *      Defina os atributos de music
                                     * 
                                     *      Adicione artist em media;   
                                     *      Adicione album em artist;
                                     *      Adicione music em album;
                                     * 
                                     *
                                     * Passo 2
                                     *      Localiza o objeto artista
                                     *      Se encontrar o artista então vá para passo 3
                                     *      Se não encontrar o artista então 
                                     *          cria o artista;
                                     *          cria o album;
                                     *          cria a música;
                                     *          Defina os atributos de artist;
                                     *          Defina os atributos de album;
                                     *          Defina os atributos de music;
                                     *          Adicione music em album;
                                     *          Adicione album em artista;
                                     *          Adicione artista em media;
                                     * 
                                     * Passo 3
                                     *      Localiza o album
                                     *      Se encontrar o album então vá para o passo 4
                                     *      Se não encontrar o album então
                                     *          cria o album
                                     *          cria a música;
                                     *          Defina os atributos de album;
                                     *          Defina os atributos de music;
                                     *          Adicione music em album;
                                     *          Adicione album em artist;
                                     * 
                                     * Passo 4
                                     *      cria music;
                                     *      Defina os atributos de music;
                                     *      Adicione a music em album;
                                     */

                                    media = carregaObjMedia(_xml_media);
                                    artist = carregaObjArtista(_xml_artist);
                                    album = carregaObjAlbum(_xml_album);
                                    music = carregaObjMusica(_xml_music);

                                    album.musicList.Add(music);
                                    artist.albumList.Add(album);
                                    media.artistList.Add(artist);
                                    lstMedia.Add(media);

                                }
                                else
                                {
                                    artist = media.artistList.Where(a => a.name == _xml_artist.Attribute("name").Value).FirstOrDefault();

                                    if (artist == null) // Artista específico não encontrado
                                    {
                                        artist = carregaObjArtista(_xml_artist);
                                        album = carregaObjAlbum(_xml_album);
                                        music = carregaObjMusica(_xml_music);

                                        album.musicList.Add(music);
                                        artist.albumList.Add(album);
                                        media.artistList.Add(artist);
                                    }
                                    else // Artista específico encontrado.
                                    {

                                        album = artist.albumList.Where(a => a.name == _xml_album.Attribute("name").Value).FirstOrDefault();
                                        if (album == null) // Album específico não encontrado
                                        {
                                            album = carregaObjAlbum(_xml_album);
                                            music = carregaObjMusica(_xml_music);

                                            album.musicList.Add(music);
                                            artist.albumList.Add(album);
                                        }
                                        else // Album específico encontrado
                                        {
                                            music = carregaObjMusica(_xml_music);
                                            album.musicList.Add(music);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return lstMedia;
        }
    }
}
