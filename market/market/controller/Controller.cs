using market.dao;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.controller
{
    public class Controller
    {
        Repository repository;
        private List<LoginTable> user;

        public Controller()
        {
            repository = new Repository();
        }

        public User Login(string kullaniciAdi, string sifre)
        {
            User result;

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                result = repository.login(kullaniciAdi, sifre);

                return result;
            }

            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList = repository.getLoginTable();
            return user;
        }

        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikSorusu) && !string.IsNullOrEmpty(guvenlikCevabi))
            {
                LoginStatus result = repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);
                if (result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return repository.changePassword(kullaniciAdi, sifre);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public string checkEmailAddress(string kullaniciAdi)
        {
            return repository.checkEmailAddreess(kullaniciAdi);
        }

        public Urun urunuGetir(string barkod)
        {
            if (!string.IsNullOrEmpty(barkod))
            {
                return repository.urunuGetir(barkod);
            }
            return null;
        }

        public List<User> tumKullanicilariGetir()
        {
            Controller controller = new Controller();
            return repository.tumKullanicilariGetir();
        }

        public LoginStatus KullaniciEkle(User user)
        {
            if (!string.IsNullOrEmpty(user.kullaniciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.emailAdres) && !string.IsNullOrEmpty(user.guvenlikSorusu) && !string.IsNullOrEmpty(user.GuvenlikCevabi))
            {
                Controller controller = new Controller();
                LoginStatus sonuc = repository.KullaniciEkle(user);
                return sonuc;
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }


        public LoginStatus KullaniciGuncelle(User user)
        {
            return repository.KullaniciGuncelle(user);
        }

        public LoginStatus kullaniciSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.kullaniciSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }

        public List<Urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir(repository.GetDr());
        }

        public LoginStatus urunEkle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.urunIsim) && !string.IsNullOrEmpty(urun.barkodKod))
            {
                return repository.urunEkle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus urunGuncelle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.urunIsim) && !string.IsNullOrEmpty(urun.barkodKod))
            {
                return repository.urunGuncelle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus urunSil(String id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.urunSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
    }
}