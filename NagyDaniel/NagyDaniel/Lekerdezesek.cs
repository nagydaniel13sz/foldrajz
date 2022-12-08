using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyDaniel
{
    class Lekerdezes
    {
        internal int sorszam;
        internal string leiras;
        internal string query;

        public Lekerdezes(int sorszam, string leiras, string query)
        {
            this.sorszam = sorszam;
            this.leiras = leiras;
            this.query = query;
        }
    }

    static class Lekerdezesek
    {
        static List<Lekerdezes> osszesLekerdezes = new List<Lekerdezes>();

        public static void Load() {
            osszesLekerdezes.Add(new Lekerdezes(1, "Mi MADAGASZKÁR fővárosa?", "SELECT `fovaros` FROM `orszagok` WHERE `orszag`='MADAGASZKÁR';"));
            osszesLekerdezes.Add(new Lekerdezes(2, "Melyik ország fővárosa OUAGADOUGOU?", "SELECT`orszag`  FROM `orszagok` WHERE `fovaros`='OUAGADOUGOU';"));
            osszesLekerdezes.Add(new Lekerdezes(3, "Melyik ország autójele a TT?", "SELECT  `orszag`FROM `orszagok` WHERE `autojel`='TT'"));
            osszesLekerdezes.Add(new Lekerdezes(4, "Melyik ország pénzének jele az SGD?", "SELECT  `orszag`FROM `orszagok` WHERE `penzjel`='SGD'"));
            osszesLekerdezes.Add(new Lekerdezes(5, "Melyik ország nemzetközi telefon-hívószáma a 61?", "SELECT  `orszag`FROM `orszagok` WHERE `telefon`=61"));
            osszesLekerdezes.Add(new Lekerdezes(6, "Mekkora területű Monaco?", "SELECT  `terulet`FROM `orszagok` WHERE `orszag`='MONACO'"));
            osszesLekerdezes.Add(new Lekerdezes(7, "Hányan laknak Máltán?", "SELECT  `nepesseg`FROM `orszagok` WHERE `orszag`='MÁLTA'"));
            osszesLekerdezes.Add(new Lekerdezes(8, "Mennyi Japán népsűrűsége? ", "SELECT  (`nepesseg`/`terulet`) as nepsurureg FROM `orszagok` WHERE `orszag`='JAPÁN'"));
            osszesLekerdezes.Add(new Lekerdezes(9, "Hány lakosa van a Földnek? ", "SELECT  sum(`nepesseg`) as lakossag FROM `orszagok`"));
            osszesLekerdezes.Add(new Lekerdezes(10, "Mennyi az országok területe összesen?", "SELECT  sum(`terulet`) as lakossag FROM `orszagok`"));
            osszesLekerdezes.Add(new Lekerdezes(11, "Mennyi az országok átlagos népessége? ", "SELECT  AVG(`nepesseg`) as atlaglakossag FROM `orszagok`"));
            osszesLekerdezes.Add(new Lekerdezes(12, "Mennyi az országok átlagos területe?", "SELECT  AVG(`terulet`) as terulet FROM `orszagok`"));
            osszesLekerdezes.Add(new Lekerdezes(13, "Mennyi a Föld népsűrűsége?", "SELECT  (`nepesseg`/`terulet`)as nepsuruseg FROM `orszagok`"));
            osszesLekerdezes.Add(new Lekerdezes(14, "Hány 1.000.000 km2-nél nagyobb területű ország van? ", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `terulet`>1000000"));
            osszesLekerdezes.Add(new Lekerdezes(15, "Hány 100 km2-nél kisebb területű ország van?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `terulet`<100"));
            osszesLekerdezes.Add(new Lekerdezes(16, "Hány 20.000 főnél kevesebb lakosú ország van?", "SELECT COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `nepesseg`<20"));
            osszesLekerdezes.Add(new Lekerdezes(17, "Hány országra igaz, hogy területe kisebb 100 km2-nél, vagy pedig a lakossága kevesebb 20.000 főnél?", "SELECT COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `nepesseg`<20 OR `terulet`<100"));
            osszesLekerdezes.Add(new Lekerdezes(18, "Hány ország területe 50.000 és 150.000 km2 közötti?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `terulet` BETWEEN 150 and 50000"));
            osszesLekerdezes.Add(new Lekerdezes(19, "ány ország lakossága 8 és 12 millió közötti?", "SELECT COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `nepesseg` BETWEEN 8000 AND 12000"));
            osszesLekerdezes.Add(new Lekerdezes(20, "Mely fővárosok népesebbek 20 millió főnél?", "SELECT `fovaros` FROM `orszagok` WHERE `nep_fovaros`>20000"));
            osszesLekerdezes.Add(new Lekerdezes(21, "Mely országok népsűrűsége nagyobb 500 fő/km2-nél?", "SELECT `orszag` FROM `orszagok` WHERE (`nepesseg`/`terulet`)>0.5"));
            osszesLekerdezes.Add(new Lekerdezes(22, "Hány ország államformája köztársaság?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `allamforma`='köztársaság'"));
            osszesLekerdezes.Add(new Lekerdezes(23, "Mely országok pénzneme a kelet-karib dollár?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `penznem`='kelet-karib dollár'"));
            osszesLekerdezes.Add(new Lekerdezes(24, "Hány ország nevében van benne az 'ORSZÁG' szó?", "SELECT COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `orszag`LIKE '%ORSZÁG';"));
            osszesLekerdezes.Add(new Lekerdezes(25, "Mely országokban korona a hivatalos fizetőeszköz?", "SELECT `orszag` FROM `orszagok` WHERE `penznem` like '%korona%';"));
            osszesLekerdezes.Add(new Lekerdezes(26, "Mennyi Európa területe?", "SELECT SUM(`terulet`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Európa%';"));
            osszesLekerdezes.Add(new Lekerdezes(27, "Mennyi Európa lakossága?", "SELECT SUM(`nepesseg`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Európa%'"));
            osszesLekerdezes.Add(new Lekerdezes(28, "Mennyi Európa népsűrűsége?", "SELECT (SUM(`nepesseg`)/`terulet`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Európa%';"));
            osszesLekerdezes.Add(new Lekerdezes(29, "Hány ország van Afrikában?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `foldr_hely` LIKE '%Afrika%'"));
            osszesLekerdezes.Add(new Lekerdezes(30, "Mennyi Afrika lakossága?", "SELECT SUM(`nepesseg`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Afrika%'"));
            osszesLekerdezes.Add(new Lekerdezes(31, "Mennyi Afrika népsűrűsége?", "SELECT (SUM(`nepesseg`)/`terulet`) FROM `orszagok` WHERE `foldr_hely` LIKE '%Afrika%'"));
            osszesLekerdezes.Add(new Lekerdezes(32, "Melyek a szigetországok?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `foldr_hely` LIKE '%sziget%' AND `foldr_hely` NOT LIKE '%félsziget%'"));
            osszesLekerdezes.Add(new Lekerdezes(33, "Mely országok államformája hercegség, vagy királyság?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `allamforma` LIKE '%hercegség%' OR `allamforma` LIKE '%királyság%'"));
            osszesLekerdezes.Add(new Lekerdezes(34, "Hány országnak nincs autójelzése?", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `autojel` LIKE ''"));
            osszesLekerdezes.Add(new Lekerdezes(35, "Mennyi a váltószáma az aprópénznek azokban az országokban, ahol nem 100?", "Nem Ertem"));
            osszesLekerdezes.Add(new Lekerdezes(36, "Hány ország területe kisebb Magyarországénál? ", "SELECT  COUNT(`id`)as orszagokszama FROM `orszagok` WHERE `terulet`<(SELECT `terulet` FROM `orszagok` WHERE `orszag` LIKE 'MAGYARORSZÁG')"));
            osszesLekerdezes.Add(new Lekerdezes(37, "Melyik a legnagyobb területű ország, és mennyi a területe? ", "SELECT `orszag`,`terulet` FROM `orszagok` ORDER BY `terulet` DESC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(38, "Melyik a legkisebb területű ország, és mennyi a területe?", "SELECT `orszag`,`terulet` FROM `orszagok` ORDER BY `terulet` ASC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(39, "Melyik a legnépesebb ország, és hány lakosa van?", "SELECT `orszag`,`nepesseg` FROM `orszagok` ORDER BY `nepesseg` DESC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(40, "Melyik a legkisebb népességű ország, és hány lakosa van?", "SELECT `orszag`, `nepesseg` FROM `orszagok` ORDER BY  `nepesseg` ASC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(41, "Melyik a legsűrűbben lakott ország, és mennyi a népsűrűsége?", "SELECT `orszag`, (`nepesseg`/`terulet`)as nepsuruseg FROM `orszagok` ORDER BY  (`nepesseg`/`terulet`) DESC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(42, "Melyik a legritkábban lakott ország, és mennyi a népsűrűsége?", "SELECT `orszag`, (`nepesseg`/`terulet`)as nepsuruseg FROM `orszagok` ORDER BY  (`nepesseg`/`terulet`) ASC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(43, "Melyik a legnagyobb afrikai ország és mekkora?", "SELECT `orszag`,`terulet` FROM `orszagok` WHERE `foldr_hely`='*Afrika*' ORDER BY `terulet` DESC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(44, "Melyik a legkisebb amerikai ország és hányan lakják?", "SELECT `orszag`,`nepesseg` FROM `orszagok` WHERE `foldr_hely`='*Afrika*' ORDER BY `terulet` ASC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(45, "Melyik az első három legsűrűbben lakott 'országméretű' ország (tehát nem város- vagy törpeállam)? ", "SELECT `orszag` FROM `orszagok` WHERE `foldr_hely` NOT LIKE '%törpeállam%' AND `foldr_hely` NOT LIKE '%városállam%' ORDER BY  (`nepesseg`/`terulet`) DESC LIMIT 3"));
            osszesLekerdezes.Add(new Lekerdezes(46, "Melyik a világ hat legnépesebb fővárosa?", "SELECT `fovaros` FROM `orszagok` ORDER BY fovaros DESC LIMIT 6"));
            osszesLekerdezes.Add(new Lekerdezes(47, "Melyik tíz ország egy főre jutó GDP-je a legnagyobb?", "SELECT `orszag` FROM `orszagok` ORDER BY (gdp/nepesseg) DESC LIMIT 10"));
            osszesLekerdezes.Add(new Lekerdezes(48, "elyik tíz ország össz-GDP-je a legnagyobb?", "SELECT `orszag` FROM `orszagok` ORDER BY gdp DESC LIMIT 10"));
            osszesLekerdezes.Add(new Lekerdezes(49, "Melyik országban a legszegényebbek az emberek?", "SELECT `orszag` FROM `orszagok` ORDER BY (gdp/nepesseg) ASC LIMIT 1"));
            osszesLekerdezes.Add(new Lekerdezes(50, "Melyik a 40. legkisebb területű ország? ", "SELECT orszagok.orszag FROM orszagok ORDER BY orszagok.terulet LIMIT 1 OFFSET 39;"));
            osszesLekerdezes.Add(new Lekerdezes(51, "Melyik a 15. legkisebb népsűrűségű ország?", "SELECT orszagok.orszag FROM orszagok ORDER BY orszagok.terulet LIMIT 1 OFFSET 15;"));
            osszesLekerdezes.Add(new Lekerdezes(52, "Melyik a 61. legnagyobb népsűrűségű ország?", "SELECT orszagok.orszag FROM orszagok ORDER BY orszagok.terulet DESC LIMIT 1 OFFSET 61;"));
            osszesLekerdezes.Add(new Lekerdezes(53, "Melyik három ország területe hasonlít leginkább Magyaroszág méretéhez? ", "SET @MO_terulet =(SELECT orszagok.terulet FROM orszagok WHERE orszagok.orszag LIKE 'MAGYARORSZÁG'); SELECT orszagok.orszag, orszagok.terulet, ROUND(ABS(orszagok.terulet - @MO_terulet), 2) AS 'Kulonbseg' FROM orszagok WHERE orszagok.orszag NOT LIKE 'MAGYARORSZÁG' ORDER BY Kulonbseg LIMIT 3;"));
            osszesLekerdezes.Add(new Lekerdezes(54, "Az emberek hányadrésze él Ázsiában?", "SET @AzsiaLakossag =(SELECT SUM(orszagok.nepesseg) FROM orszagok WHERE LOWER(orszagok.foldr_hely) LIKE '%Ázsia%');SET @FoldLakossag =(SELECT SUM(orszagok.nepesseg) FROM orszagok); SELECT ROUND((@AzsiaLakossag / @FoldLakossag), 6) AS 'Ázsiai lakosok aránya a földön';"));
            osszesLekerdezes.Add(new Lekerdezes(55, "A szárazföldek mekkora hányadát foglalja el Oroszország?", "KIFUTOTTAM AZ IDOBOL ........"));
            osszesLekerdezes.Add(new Lekerdezes(56, "Az emberek hány százaléka fizet euroval?", "KIFUTOTTAM AZ IDOBOL ........"));
            osszesLekerdezes.Add(new Lekerdezes(57, "Hányszorosa a leggazdagabb ország egy főre jutó GDP-je a legszegényebb ország egy főre jutó GDP-jének?  ", "KIFUTOTTAM AZ IDOBOL ........"));
            osszesLekerdezes.Add(new Lekerdezes(58, "A világ össz-GDP-jének hány százalékát adja az USA?", "KIFUTOTTAM AZ IDOBOL ........"));
            osszesLekerdezes.Add(new Lekerdezes(59, "A világ össz-GDP-jének hány százalékát adja az euroövezet?", "......"));
            osszesLekerdezes.Add(new Lekerdezes(60, "Melyek azok az átlagnál gazdagabb országok, amelyek nem az európai vagy az amerikai kontinensen találhatóak?", "SET @Atlag_GDP =(SELECT AVG(orszagok.gdp)FROM orszagok); SELECT orszagok.orszag FROM orszagok WHERE orszagok.gdp > @Atlag_GDP AND LOWER(orszagok.foldr_hely) NOT LIKE '%európa%' AND LOWER(orszagok.foldr_hely) NOT LIKE '%amerika%';"));
            osszesLekerdezes.Add(new Lekerdezes(61, "Milyen államformák léteznek Európában?", "KIFUTOTTAM AZ IDOBOL ........"));
            osszesLekerdezes.Add(new Lekerdezes(62, "Hányféle államforma létezik a világon?", "NEM"));
            osszesLekerdezes.Add(new Lekerdezes(63, "Hányféle fizetőeszközt használnak Európában az eurón kívül?", "12300"));
            osszesLekerdezes.Add(new Lekerdezes(64, "ely pénznemeket használják több országban is?", "SELECT orszagok.penznem, COUNT(orszagok.id) AS 'db' FROM orszagok GROUP BY orszagok.penznem HAVING db > 1;  "));

        }

        public static Lekerdezes Query(int lekerdezesSzama)
        {
            for(int i=0; i<osszesLekerdezes.Count; i++)
            {
                if (lekerdezesSzama == osszesLekerdezes[i].sorszam)
                    return osszesLekerdezes[i];
            }

            return null;
            
        }

        

        
    }
}
