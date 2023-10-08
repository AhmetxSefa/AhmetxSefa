using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_projem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Meslek Lisesi 9. sınıf ortalama hesaplayan program

            // dönem seçme

            string donem;
            Console.WriteLine("Döneminizi giriniz: ");
            donem = Console.ReadLine();

            int[] krediler = {1,2,5,6};

            int turk_dili_ve_edebiyati1, turk_dili_ve_edebiyati2, turk_dili_ve_edebiyati3, turk_dili_ve_edebiyati4, tdve_ort,
                    din_kulturu1, din_kulturu2, din_kulturu3, din_kulturu4, dkvab_ort, tarih1, tarih2, tarih3, tarih4, t_ort,
                    cografya1, cografya2, cografya3, cografya4, c_ort, matematik1, matematik2, matematik3, matematik4, m_ort,
                    fizik1, fizik2, fizik3, fizik4, f_ort, kimya1, kimya2, kimya3, kimya4, k_ort, biyoloji1, biyoloji2, biyoloji3,
                    biyoloji4, b_ort, yabanci_dil1, yabanci_dil2, yabanci_dil3, yabanci_dil4, yd_ort, beden_egitimi1,
                    beden_egitimi2, beden_egitimi3, beden_egitimi4, be_ort, gorsel_sanatlar1, gorsel_sanatlar2, gorsel_sanatlar3,
                    gorsel_sanatlar4, gs_ort, saglik_bilgisi_ve_trafik_kulturu1, saglik_bilgisi_ve_trafik_kulturu2,
                    saglik_bilgisi_ve_trafik_kulturu3, saglik_bilgisi_ve_trafik_kulturu4, sg_ort, ort;

            if (donem == "birinci")
            {

                Console.Write("Türk Dili ve Edebiyatı birinci sınav notunuz: ");
                turk_dili_ve_edebiyati1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Türk Dili ve Edebiyatı ikinci sınav notunuz: ");
                turk_dili_ve_edebiyati2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Türk Dili ve Edebiyatı birinci performans notunuz: ");
                turk_dili_ve_edebiyati3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Türk Dili ve Edebiyatı ikinci performans notunuz: ");
                turk_dili_ve_edebiyati4 = Convert.ToInt32(Console.ReadLine());

                // türk dili ve edebiyatı ders ortalaması hesaplaması

                tdve_ort = (turk_dili_ve_edebiyati1 + turk_dili_ve_edebiyati2 + turk_dili_ve_edebiyati3 + turk_dili_ve_edebiyati4) / 4;

                if (tdve_ort >= 70)
                {
                    Console.WriteLine("Dersten geçtiniz ve tüm dersler ortalamanız 50 olursa sınıfı geçebileceksiniz " + tdve_ort);
                }
                else
                {
                    Console.WriteLine("Koşulsuz sınıfta kaldınız " + tdve_ort);
                }

                Console.Write("Din Kültürü birinci sınav notunuz: ");
                din_kulturu1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Din Kültürü ikinci sınav notunuz: ");
                din_kulturu2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Din Kültürü birinci performans notunuz: ");
                din_kulturu3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Din Kültürü ikinci performans notunuz: ");
                din_kulturu4 = Convert.ToInt32(Console.ReadLine());

                // din kültürü ve ahlak bilgisi ders ortalaması hesaplaması

                dkvab_ort = (din_kulturu1 + din_kulturu2 + din_kulturu3 + din_kulturu4) / 4;

                if (dkvab_ort >= 50)
                {
                    Console.WriteLine("Din Kültüründen geçtiniz " + dkvab_ort);
                }
                else
                {
                    Console.WriteLine("Din Kültüründen kaldınız " + dkvab_ort);
                }

                Console.Write("Tarih birinci sınav notunuz: ");
                tarih1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tarih ikinci sınav notunuz: ");
                tarih2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tarih birinci performans notunuz: ");
                tarih3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tarih ikinci performans notunuz: ");
                tarih4 = Convert.ToInt32(Console.ReadLine());

                // tarih ders ortalaması hesaplaması.

                t_ort = (tarih1 + tarih2 + tarih3 + tarih4) / 4;

                if (t_ort >= 50)
                {
                    Console.WriteLine("Tarihden geçtiniz " + t_ort);
                }
                else
                {
                    Console.WriteLine("Tarihden kaldınız " + t_ort);
                }

                Console.Write("Coğrafya birinci sınav notunuz: ");
                cografya1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coğrafya ikinci sınav notunuz: ");
                cografya2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coğrafya birinci performans notunuz: ");
                cografya3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coğrafya ikinci performans notunuz: ");
                cografya4 = Convert.ToInt32(Console.ReadLine());

                // coğrafya ders ortalaması hesaplaması

                c_ort = (cografya1 + cografya2 + cografya3 + cografya4) / 4;

                if (c_ort >= 50)
                {
                    Console.WriteLine("Coğrafyadan geçtiniz " + c_ort);
                }
                else
                {
                    Console.WriteLine("Coğrafyadan kaldınız " + c_ort);
                }

                Console.Write("Matematik birinci sınav notunuz: ");
                matematik1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Matematik ikinci sınav notunuz: ");
                matematik2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Matematik birinci performans notunuz: ");
                matematik3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Matematik ikinci performans notunuz: ");
                matematik4 = Convert.ToInt32(Console.ReadLine());

                // matematik ders ortalaması hesaplaması

                m_ort = (matematik1 + matematik2 + matematik3 + matematik4) / 4;

                if (m_ort >= 50)
                {
                    Console.WriteLine("Matematikten geçtiniz " + m_ort);
                }
                else
                {
                    Console.WriteLine("Matematikten kaldınız " + m_ort);
                }

                Console.Write("Fizik birinci sınav notunuz: ");
                fizik1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fizik ikinci sınav notunuz: ");
                fizik2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fizik birinci performans notunuz: ");
                fizik3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fizik ikinci performans notunuz: ");
                fizik4 = Convert.ToInt32(Console.ReadLine());

                // fizik ders ortalaması hesaplaması.

                f_ort = (fizik1 + fizik2 + fizik3 + fizik4) / 4;

                if (f_ort >= 50)
                {
                    Console.WriteLine("Fizikten geçtiniz " + f_ort);
                }
                else
                {
                    Console.WriteLine("Fizikten Kaldınız " + f_ort);
                }

                Console.Write("Kimya birinci sınav notunuz: ");
                kimya1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya ikinci sınav notunuz: ");
                kimya2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya birinci performans notunuz: ");
                kimya3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya ikinci performans notunuz: ");
                kimya4 = Convert.ToInt32(Console.ReadLine());

                // kimya ders ortalaması hesaplaması.

                k_ort = (kimya1 + kimya2 + kimya3 + kimya4) / 4;

                if (k_ort >= 50)
                {
                    Console.WriteLine("Kimyadan geçtiniz " + k_ort);
                }
                else
                {
                    Console.WriteLine("Kimyadan kaldınız " + k_ort);
                }

                Console.Write("Biyoloji birinci sınav notunuz: ");
                biyoloji1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biyoloji ikinci sınav notunuz: ");
                biyoloji2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biyoloji birinci performans notunuz: ");
                biyoloji3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biyoloji ikinci performans notunuz: ");
                biyoloji4 = Convert.ToInt32(Console.ReadLine());

                // biyoloji ders ortalaması hesaplaması.

                b_ort = (biyoloji1 + biyoloji2 + biyoloji3 + biyoloji4) / 4;

                if (b_ort >= 50)
                {
                    Console.WriteLine("Biyolojiden geçtiniz " + b_ort);
                }
                else
                {
                    Console.WriteLine("Biyolojiden Kaldınız " + b_ort);
                }

                Console.Write("Yabancı Dil birinci sınav notunuz: ");
                yabanci_dil1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yabanci Dil ikinci sınav notunuz: ");
                yabanci_dil2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yabanci Dil birinci performans notunuz: ");
                yabanci_dil3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yabanci Dil ikinci performans notunuz: ");
                yabanci_dil4 = Convert.ToInt32(Console.ReadLine());

                // Yabancı Dil ders ortalaması hesaplaması

                yd_ort = (yabanci_dil1 + yabanci_dil2 + yabanci_dil3 + yabanci_dil4) / 4;

                if (yd_ort >= 50)
                {
                    Console.WriteLine("Yabancı Dilden geçtiniz " + yd_ort);
                }
                else
                {
                    Console.WriteLine("Yabancı Dilden Kaldınız " + yd_ort);
                }

                Console.Write("Beden Eğitimi birinci sınav notunuz: ");
                beden_egitimi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Beden Eğitimi ikinci sınav notunuz: ");
                beden_egitimi2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Beden Eğitimi birinci performans notunuz: ");
                beden_egitimi3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Beden Eğitimi ikinci performans notunuz: ");
                beden_egitimi4 = Convert.ToInt32(Console.ReadLine());

                // Beden Eğitimi ders ortalaması hesaplaması

                be_ort = (beden_egitimi1 + beden_egitimi2 + beden_egitimi3 + beden_egitimi4) / 4;

                if (be_ort >= 50)
                {
                    Console.WriteLine("Beden eğitimi dersinden geçtiniz " + be_ort);
                }
                else
                {
                    Console.WriteLine("Beden Eğitimi dersinden kaldınız " + be_ort);
                }

                Console.Write("Görsel Sanatlar birinci sınav notunuz: ");
                gorsel_sanatlar1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Görsel Sanatlar ikinci sınav notunuz: ");
                gorsel_sanatlar2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Görsel Sanatlar birinci performans notunuz: ");
                gorsel_sanatlar3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Görsel Sanatlar ikinci performans notunuz: ");
                gorsel_sanatlar4 = Convert.ToInt32(Console.ReadLine());

                //Görsel Sanatlar deres ortalaması hesaplaması

                gs_ort = (gorsel_sanatlar1 + gorsel_sanatlar2 + gorsel_sanatlar3 + gorsel_sanatlar4) / 4;

                if (gs_ort >= 50)
                {
                    Console.WriteLine("Görsel Sanatlar dersinden Geçtiniz " + gs_ort);
                }
                else
                {
                    Console.WriteLine("Görsel Sanatlar Dersinden kaldınız " + gs_ort);
                }

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü birinci sınav notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü ikinci sınav notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü birinci performans notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü ikinci performans notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu4 = Convert.ToInt32(Console.ReadLine());

                //Sağlık Bilgisi ve Trafik Külütürü ders ortalama hesaplaması

                sg_ort = (saglik_bilgisi_ve_trafik_kulturu1 + saglik_bilgisi_ve_trafik_kulturu2 +
                    saglik_bilgisi_ve_trafik_kulturu3 + saglik_bilgisi_ve_trafik_kulturu4) / 4;

                if(sg_ort >= 50)
                {
                    Console.WriteLine("Sağlık Bilgisi ve Trafik Kültürü dersinden geçtiniz");
                }
                else
                {
                    Console.WriteLine("Sağlık Bilgisi ve Trafik Kültürü dersinden kaldınız");
                }

                // Dönem ortalaması hesaplaması

                ort = ((tdve_ort * krediler[1]) + (dkvab_ort * krediler[1]) + (t_ort * krediler[1]) + (c_ort * krediler[1])
                    + (c_ort * krediler[1]) + (m_ort * krediler[3]) + (f_ort * krediler[1]) + (k_ort * krediler[1])
                    + (k_ort * krediler[1]) + (b_ort * krediler[1]) + (yd_ort * krediler[2]) + (be_ort * krediler[1])
                    + (gs_ort * krediler[1]) + (sg_ort * krediler[0])) / 33;

                if (ort >= 50)
                {
                    Console.WriteLine("Tebrikler ortalamayı tutturdunuz ikinci dönem de sıkı çalış "+ ort);
                }
                else
                {
                    Console.WriteLine("Üzgünüm ortalamanız düşük ikinci dönem daha sıkı çalışmalısın "+ ort);
                }

            }

            else if (donem == "ikinci")
            {
                Console.Write("Türk Dili ve Edebiyatı birinci sınav notunuz: ");
                turk_dili_ve_edebiyati1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Türk Dili ve Edebiyatı ikinci sınav notunuz: ");
                turk_dili_ve_edebiyati2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Türk Dili ve Edebiyatı birinci performans notunuz: ");
                turk_dili_ve_edebiyati3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Türk Dili ve Edebiyatı ikinci performans notunuz: ");
                turk_dili_ve_edebiyati4 = Convert.ToInt32(Console.ReadLine());

                // türk dili ve edebiyatı ders ortalaması hesaplaması

                tdve_ort = (turk_dili_ve_edebiyati1 + turk_dili_ve_edebiyati2 + turk_dili_ve_edebiyati3 + turk_dili_ve_edebiyati4) / 4;

                if (tdve_ort >= 70)
                {
                    Console.WriteLine("Dersten geçtiniz ve tüm dersler ortalamanız 50 olursa sınıfı geçebileceksiniz " + tdve_ort);
                }
                else
                {
                    Console.WriteLine("Koşulsuz sınıfta kaldınız " + tdve_ort);
                }

                Console.Write("Din Kültürü birinci sınav notunuz: ");
                din_kulturu1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Din Kültürü ikinci sınav notunuz: ");
                din_kulturu2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Din Kültürü birinci performans notunuz: ");
                din_kulturu3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Din Kültürü ikinci performans notunuz: ");
                din_kulturu4 = Convert.ToInt32(Console.ReadLine());

                // din kültürü ve ahlak bilgisi ders ortalaması hesaplaması

                dkvab_ort = (din_kulturu1 + din_kulturu2 + din_kulturu3 + din_kulturu4) / 4;

                if (dkvab_ort >= 50)
                {
                    Console.WriteLine("Din Kültüründen geçtiniz " + dkvab_ort);
                }
                else
                {
                    Console.WriteLine("Din Kültüründen kaldınız " + dkvab_ort);
                }

                Console.Write("Tarih birinci sınav notunuz: ");
                tarih1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tarih ikinci sınav notunuz: ");
                tarih2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tarih birinci performans notunuz: ");
                tarih3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Tarih ikinci performans notunuz: ");
                tarih4 = Convert.ToInt32(Console.ReadLine());

                // tarih ders ortalaması hesaplaması.

                t_ort = (tarih1 + tarih2 + tarih3 + tarih4) / 4;

                if (t_ort >= 50)
                {
                    Console.WriteLine("Tarihden geçtiniz " + t_ort);
                }
                else
                {
                    Console.WriteLine("Tarihden kaldınız " + t_ort);
                }

                Console.Write("Coğrafya birinci sınav notunuz: ");
                cografya1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coğrafya ikinci sınav notunuz: ");
                cografya2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coğrafya birinci performans notunuz: ");
                cografya3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coğrafya ikinci performans notunuz: ");
                cografya4 = Convert.ToInt32(Console.ReadLine());

                // coğrafya ders ortalaması hesaplaması

                c_ort = (cografya1 + cografya2 + cografya3 + cografya4) / 4;

                if (c_ort >= 50)
                {
                    Console.WriteLine("Coğrafyadan geçtiniz " + c_ort);
                }
                else
                {
                    Console.WriteLine("Coğrafyadan kaldınız " + c_ort);
                }

                Console.Write("Matematik birinci sınav notunuz: ");
                matematik1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Matematik ikinci sınav notunuz: ");
                matematik2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Matematik birinci performans notunuz: ");
                matematik3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Matematik ikinci performans notunuz: ");
                matematik4 = Convert.ToInt32(Console.ReadLine());

                // matematik ders ortalaması hesaplaması

                m_ort = (matematik1 + matematik2 + matematik3 + matematik4) / 4;

                if (m_ort >= 50)
                {
                    Console.WriteLine("Matematikten geçtiniz " + m_ort);
                }
                else
                {
                    Console.WriteLine("Matematikten kaldınız " + m_ort);
                }

                Console.Write("Fizik birinci sınav notunuz: ");
                fizik1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fizik ikinci sınav notunuz: ");
                fizik2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fizik birinci performans notunuz: ");
                fizik3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Fizik ikinci performans notunuz: ");
                fizik4 = Convert.ToInt32(Console.ReadLine());

                // fizik ders ortalaması hesaplaması.

                f_ort = (fizik1 + fizik2 + fizik3 + fizik4) / 4;

                if (f_ort >= 50)
                {
                    Console.WriteLine("Fizikten geçtiniz " + f_ort);
                }
                else
                {
                    Console.WriteLine("Fizikten Kaldınız " + f_ort);
                }

                Console.Write("Kimya birinci sınav notunuz: ");
                kimya1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya ikinci sınav notunuz: ");
                kimya2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya birinci performans notunuz: ");
                kimya3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya ikinci performans notunuz: ");
                kimya4 = Convert.ToInt32(Console.ReadLine());

                // kimya ders ortalaması hesaplaması.

                k_ort = (kimya1 + kimya2 + kimya3 + kimya4) / 4;

                if (k_ort >= 50)
                {
                    Console.WriteLine("Kimyadan geçtiniz " + k_ort);
                }
                else
                {
                    Console.WriteLine("Kimyadan kaldınız " + k_ort);
                }

                Console.Write("Biyoloji birinci sınav notunuz: ");
                biyoloji1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biyoloji ikinci sınav notunuz: ");
                biyoloji2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biyoloji birinci performans notunuz: ");
                biyoloji3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Biyoloji ikinci performans notunuz: ");
                biyoloji4 = Convert.ToInt32(Console.ReadLine());

                // biyoloji ders ortalaması hesaplaması.

                b_ort = (biyoloji1 + biyoloji2 + biyoloji3 + biyoloji4) / 4;

                if (b_ort >= 50)
                {
                    Console.WriteLine("Biyolojiden geçtiniz " + b_ort);
                }
                else
                {
                    Console.WriteLine("Biyolojiden Kaldınız " + b_ort);
                }

                Console.Write("Yabancı Dil birinci sınav notunuz: ");
                yabanci_dil1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yabanci Dil ikinci sınav notunuz: ");
                yabanci_dil2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yabanci Dil birinci performans notunuz: ");
                yabanci_dil3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yabanci Dil ikinci performans notunuz: ");
                yabanci_dil4 = Convert.ToInt32(Console.ReadLine());

                // Yabancı Dil ders ortalaması hesaplaması

                yd_ort = (yabanci_dil1 + yabanci_dil2 + yabanci_dil3 + yabanci_dil4) / 4;

                if (yd_ort >= 50)
                {
                    Console.WriteLine("Yabancı Dilden geçtiniz " + yd_ort);
                }
                else
                {
                    Console.WriteLine("Yabancı Dilden Kaldınız " + yd_ort);
                }

                Console.Write("Kimya birinci sınav notunuz: ");
                beden_egitimi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya ikinci sınav notunuz: ");
                beden_egitimi2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya birinci performans notunuz: ");
                beden_egitimi3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Kimya ikinci performans notunuz: ");
                beden_egitimi4 = Convert.ToInt32(Console.ReadLine());

                // Beden Eğitimi ders ortalaması hesaplaması

                be_ort = (beden_egitimi1 + beden_egitimi2 + beden_egitimi3 + beden_egitimi4) / 4;

                if (be_ort >= 50)
                {
                    Console.WriteLine("Beden eğitimi dersinden geçtiniz " + be_ort);
                }
                else
                {
                    Console.WriteLine("Beden Eğitimi dersinden kaldınız " + be_ort);
                }

                Console.Write("Görsel Sanatlar birinci sınav notunuz: ");
                gorsel_sanatlar1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Görsel Sanatlar ikinci sınav notunuz: ");
                gorsel_sanatlar2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Görsel Sanatlar birinci performans notunuz: ");
                gorsel_sanatlar3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Görsel Sanatlar ikinci performans notunuz: ");
                gorsel_sanatlar4 = Convert.ToInt32(Console.ReadLine());

                //Görsel Sanatlar deres ortalaması hesaplaması

                gs_ort = (gorsel_sanatlar1 + gorsel_sanatlar2 + gorsel_sanatlar3 + gorsel_sanatlar4) / 4;

                if (gs_ort >= 50)
                {
                    Console.WriteLine("Görsel Sanatlar dersinden Geçtiniz " + gs_ort);
                }
                else
                {
                    Console.WriteLine("Görsel Sanatlar Dersinden kaldınız " + gs_ort);
                }

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü birinci sınav notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü ikinci sınav notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü birinci performans notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sağlık Bilgisi ve Trafik Kültürü ikinci performans notunuz: ");
                saglik_bilgisi_ve_trafik_kulturu4 = Convert.ToInt32(Console.ReadLine());

                //Sağlık Bilgisi ve Trafik Külütürü ders ortalama hesaplaması

                sg_ort = (saglik_bilgisi_ve_trafik_kulturu1 + saglik_bilgisi_ve_trafik_kulturu2 +
                    saglik_bilgisi_ve_trafik_kulturu3 + saglik_bilgisi_ve_trafik_kulturu4) / 4;

                if (sg_ort >= 50)
                {
                    Console.WriteLine("Sağlık Bilgisi ve Trafik Kültürü dersinden geçtiniz");
                }
                else
                {
                    Console.WriteLine("Sağlık Bilgisi ve Trafik Kültürü dersinden kaldınız");
                }

                // Dönem ortalaması hesaplaması

                ort = ((tdve_ort * krediler[1]) + (dkvab_ort * krediler[1]) + (t_ort * krediler[1]) + (c_ort * krediler[1])
                    + (c_ort * krediler[1]) + (m_ort * krediler[3]) + (f_ort * krediler[1]) + (k_ort * krediler[1])
                    + (k_ort * krediler[1]) + (b_ort * krediler[1]) + (yd_ort * krediler[2]) + (be_ort * krediler[1])
                    + (gs_ort * krediler[1]) + (sg_ort * krediler[0])) / 33;

                if (ort >= 50)
                {
                    Console.WriteLine("Tebrikler ortalamayı tutturdunuz ikinci dönem de sıkı çalış "+ ort);
                }
                else
                {
                    Console.WriteLine("Üzgünüm ortalamanız düşük ikinci dönem daha sıkı çalışmalısın"+ ort);
                }
                
            }
            else
            {
                Console.WriteLine("eksik ya da hatalı giriş");
            }

            Console.ReadKey();

        }
    }
}
