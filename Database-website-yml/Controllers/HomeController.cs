using Database_website_yml.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;



namespace Database_website_yml.Controllers
{
    public class HomeController : Controller
    {
        private Dictionary<string, Film> database = new Dictionary<string, Film>()
        {
            { "Ted Lasso", new Film("Ted Lasso","https://wallpaperaccess.com/full/7069351.jpg", "Ted Lasso is een hartverwarmende komedieserie die draait om de Amerikaanse coach Ted Lasso, gespeeld door Jason Sudeikis. Het verhaal begint wanneer Ted wordt ingehuurd om een voetbalteam te leiden in de Engelse Premier League, ondanks zijn gebrek aan ervaring in het coachen van voetbal. Hij staat voor de uitdaging om een team dat worstelt met interne conflicten en tegenslagen te transformeren.Wat Ted echter mist aan tactische kennis, compenseert hij ruimschoots met zijn onweerstaanbare optimisme, onconventionele aanpak en zijn vermogen om mensen te inspireren. Hij brengt positiviteit en een gevoel van gemeenschap in het team en de club, en bouwt sterke relaties op met spelers, stafleden en zelfs de sceptische fans. Gedurende de serie zien we hoe Ted en zijn team langzaam maar zeker groeien, zowel op het veld als in hun persoonlijke levens. Ted's leiderschap en levensfilosofieën raken iedereen die met hem in aanraking komt, en hij leert hen dat succes niet alleen gaat om winnen, maar ook om karakter, vriendschap en plezier hebben in wat je doet. Ted Lasso is een verfrissende serie vol humor, hart en inspiratie, waarin we getuige zijn van de transformatie van een voetbalteam en de mensen eromheen.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Kijkwijzer_AL.svg/1200px-Kijkwijzer_AL.svg.png", "https://www.youtube.com/embed/3u7EIiohs6U", "https://upload.wikimedia.org/wikipedia/commons/6/6d/Jason_Sudeikis_on_March_20%2C_2023_in_the_Oval_Office_of_the_White_House_-_P20230320AS-2571_%28cropped%29.jpg", "https://assets.mycast.io/actor_images/actor-brett-goldstein-285555_large.jpg?1634202566", "https://tv-fanatic-res.cloudinary.com/iu/s--u7E-Jplo--/t_xlarge_p/cs_srgb,f_auto,fl_strip_profile.lossy,q_auto:420/v1682686141/phil-dunster-attends-a-fyc-special-screening-of-apple-tv-plus-s.jpg", "Jason Sudeikis", "Brett Goldstein", "Phil Dunster") },
            { "Super Mario Movie", new Film("Super Mario Movie","https://sm.ign.com/t/ign_it/screenshot/default/blob_xy1q.1280.jpg", "De Super Mario Movie is een langverwachte animatiefilm gebaseerd op het iconische videospel personage Mario, gecreëerd door Nintendo. Het verhaal volgt de avonturen van Mario en zijn trouwe metgezel, Luigi, terwijl ze op een missie gaan om prinses Peach te redden uit de klauwen van de kwaadaardige Bowser, de koning van de Koopa's.In de film worden Mario en Luigi meegesleurd naar het kleurrijke en gevarieerde Mushroom Kingdom, waar ze worden geconfronteerd met allerlei obstakels, puzzels en vijanden. Met behulp van hun unieke vaardigheden en de steun van bekende personages zoals Yoshi, Toad en Princess Daisy, trotseren ze gevaarlijke werelden vol met verrassingen. Het verhaal barst van de humor, actie en nostalgie, waarbij de filmmakers de geliefde elementen uit de Super Mario-games tot leven brengen op het grote scherm. De Super Mario Movie is een episch avontuur vol magie, vriendschap en de klassieke rivaliteit tussen Mario en Bowser.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Kijkwijzer_AL.svg/1200px-Kijkwijzer_AL.svg.png", "https://www.youtube.com/embed/TnGl01FkMMo", "https://flxt.tmsimg.com/assets/71804_v9_bb.jpg", "https://resizing.flixster.com/RTuJBG1AykHqUgqAF6slzTp10SI=/ems.ZW1zLXByZC1hc3NldHMvY2VsZWJyaXRpZXMvZDhjYTgwYzUtM2Q5Ny00OTBmLTkyOWUtZDhmMDI0N2Q2YTQxLmpwZw==", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Chris_Pratt_2018.jpg/1200px-Chris_Pratt_2018.jpg", "Jack Black", "Anya Taylor-Joy", "Chris Pratt") },
            { "Back to the future", new Film("Back To The Future","https://www.usatoday.com/gcdn/-mm-/94572ad71c1c554abae670ec7bd4871e2898e3b2/c=0-142-3000-1837/local/-/media/2015/10/21/USATODAY/USATODAY/635809824922215243-AP-BACK-TO-THE-FUTURE-DAY-76890712.JPG?width=3000&height=1695&fit=crop&format=pjpg&auto=webp", "Back to the Future is een iconische sciencefictionfilm die draait om de avonturen van Marty McFly, gespeeld door Michael J. Fox. Het verhaal begint wanneer Marty per ongeluk terugreist in de tijd naar het jaar 1955 met behulp van een tijdmachine, gemaakt door de excentrieke wetenschapper Dr. Emmett Brown, oftewel Doc, gespeeld door Christopher Lloyd.In 1955 ontmoet Marty zijn eigen ouders als tieners en beseft hij dat hij hun toekomst op het spel heeft gezet. Om ervoor te zorgen dat zijn ouders verliefd worden en hij zijn eigen bestaan kan garanderen, moet Marty allerlei uitdagingen overwinnen en de tijdlijn rechtzetten. Ondertussen moet hij ook Doc helpen om een manier te vinden om terug te keren naar de toekomst.Het verhaal zit boordevol humor, spanning en avontuur, terwijl Marty en Doc proberen te navigeren door verschillende tijdperken en hun eigen lot te beïnvloeden. Back to the Future is een tijdloze klassieker die het publiek meeneemt op een reis door de tijd vol met onvergetelijke personages en memorabele momenten.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Kijkwijzer_6.svg/640px-Kijkwijzer_6.svg.png", "https://www.youtube.com/embed/WRrCVyT09ow", "https://m.media-amazon.com/images/M/MV5BMTcwNzM0MjE4NF5BMl5BanBnXkFtZTcwMDkxMzEwMw@@._V1_FMjpg_UX1000_.jpg", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Christopher_Lloyd_%2852472776099%29.jpg/1200px-Christopher_Lloyd_%2852472776099%29.jpg", "https://i.pinimg.com/236x/f0/40/83/f0408384b84f7b15d5bb4123c3480990.jpg", "Michael J. Fox", "Christopher Lloyd", "Thomas F. Wilson") },
            { "The hangover", new Film("The Hangover","https://images.pathe-thuis.nl/7467_1920x1080.jpg", "The Hangover is een hilarische komedie die draait om een groep vrienden die een wild vrijgezellenfeest beleven in Las Vegas. Het verhaal begint wanneer Doug, gespeeld door Justin Bartha, op het punt staat te trouwen en zijn beste vrienden Phil, Stu en Alan, gespeeld door Bradley Cooper, Ed Helms en Zach Galifianakis, besluiten om hem een onvergetelijke laatste nacht als vrijgezel te bezorgen. Echter, wanneer de ochtend aanbreekt, ontwaken ze in een verwoeste hotelkamer zonder enige herinnering van de vorige avond en zonder Doug. Ze raken verstrikt in een waanzinnige zoektocht doorheen Las Vegas om Doug te vinden, terwijl ze geconfronteerd worden met bizarre situaties, vreemde personages en verrassende wendingen. Terwijl ze proberen de puzzelstukjes van hun verloren nacht bij elkaar te krijgen, komen ze steeds dichter bij de waarheid en ontdekken ze dat ze betrokken zijn bij een reeks waanzinnige en komische gebeurtenissen.The Hangover is een avontuurlijke en grappige film die de kijker meeneemt op een wilde rit vol met chaos, gekke personages en onverwachte wendingen, terwijl de vrienden proberen hun vriendschap te redden en het mysterie van hun wilde nacht op te lossen.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/tlize92ffnY", "https://cdn.britannica.com/57/199057-050-CCE5410A/Bradley-Cooper-2008.jpg", "https://m.media-amazon.com/images/M/MV5BMTQwNzI3NjIwMV5BMl5BanBnXkFtZTcwMzA1OTIwMw@@._V1_.jpg", "https://m.media-amazon.com/images/M/MV5BMTk2MDQwODEwNV5BMl5BanBnXkFtZTcwNjc4MTY0NA@@._V1_.jpg", "Bradley Cooper", "Zach Galifianakis", "Ed Helms") },
            { "Avengers Endgame", new Film("Avengers Endgame","https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2019%2F06%2Favengersendgame5ce30b0b72b43-2000.jpg&q=60", "Avengers: Endgame is een episch superheldenavontuur dat het hoogtepunt vormt van het Marvel Cinematic Universe (MCU). Het verhaal begint na de verwoestende gebeurtenissen van Avengers: Infinity War, waarin de schurk Thanos de helft van al het leven in het universum heeft uitgewist. In Endgame zien we hoe de overgebleven Avengers en hun bondgenoten, waaronder Iron Man, Captain America, Thor, Hulk, Black Widow en Hawkeye, hun krachten bundelen en een plan smeden om de verlorenen terug te brengen en Thanos te verslaan. Ze moeten door de tijd reizen en de Infinity Stones verzamelen om de verwoesting ongedaan te maken. Het verhaal is doordrenkt van actie, emotie en opoffering, waarbij onze geliefde helden de ultieme strijd aangaan om het universum te redden. Het is een eerbetoon aan de jarenlange opbouw van het MCU en biedt een bevredigende conclusie aan vele verhaallijnen. Avengers: Endgame is een meeslepend en spectaculair avontuur dat fans over de hele wereld in spanning hield en een emotionele reis vormt voor zowel de personages als het publiek.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/TcMBFSGVi1c", "https://www.californiamuseum.org/sites/main/files/imagecache/lightbox/main-images/robertdowneyjr_cahalloffameinductee.png", "https://upload.wikimedia.org/wikipedia/commons/3/33/Mark_Kassen%2C_Tony_C%C3%A1rdenas_and_Chris_Evans_%28cropped%29.jpg", "https://upload.wikimedia.org/wikipedia/commons/e/e8/Chris_Hemsworth_by_Gage_Skidmore_2_%28cropped%29.jpg", "Robert Downey Jr.", "Chris Evans", "Chris Hemsworth") },
            { "Barbie", new Film("Barbie","https://media.gq-magazine.co.uk/photos/642d53389217f8b05fc7f974/master/pass/Barbie_movie_0001_Barbie___Teaser_Trailer_2_1-6_screenshot.jpeg", "Het verhaal van Barbie in 2023 brengt ons een nieuw avontuur met de iconische pop. In deze film volgen we Barbie, die een getalenteerde modeontwerpster is geworden en haar eigen modeshow organiseert in een betoverende wereld. Ze wordt omringd door kleurrijke en diverse vrienden, elk met unieke persoonlijkheden en talenten. Wanneer Barbie's modecreaties worden gestolen door een gemene modeconcurrent, gaat ze op een spannende reis om ze terug te vinden en haar show te redden. Onderweg ontdekt ze de kracht van vriendschap, doorzettingsvermogen en zelfvertrouwen. De film zit vol met magische momenten, prachtige modeshows en inspirerende boodschappen over het volgen van je dromen en geloven in jezelf. Barbie 2023 is een betoverende en hedendaagse film die jong en oud zal betoveren met zijn positieve energie en kleurrijke wereld.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Kijkwijzer_AL.svg/1200px-Kijkwijzer_AL.svg.png", "https://www.youtube.com/embed/qcGMKd8iego", "https://upload.wikimedia.org/wikipedia/commons/3/33/SYDNEY%2C_AUSTRALIA_-_JANUARY_23_Margot_Robbie_arrives_at_the_Australian_Premiere_of_%27I%2C_Tonya%27_on_January_23%2C_2018_in_Sydney%2C_Australia_%2828074883999%29_%28cropped%29.jpg", "https://m.media-amazon.com/images/M/MV5BMTQzMjkwNTQ2OF5BMl5BanBnXkFtZTgwNTQ4MTQ4MTE@._V1_.jpg", "https://cdn.britannica.com/06/242206-050-E18E3ABD/Simu-Liu-actor-2022.jpg", "Margot Robbie", "Ryan Gosling", "Simu Liu") },
            { "The Batman", new Film("The Batman","https://onetechtraveller.com/wp-content/uploads/2022/03/the-batman-2022-review-hero.jpg", "The Batman is een duistere en meeslepende superheldenfilm die een nieuwe kijk biedt op het iconische personage. Het verhaal volgt de jonge Bruce Wayne, gespeeld door Robert Pattinson, in zijn vroege jaren als de Dark Knight van Gotham City. In deze film wordt Batman geconfronteerd met een reeks gruwelijke misdaden die zijn stad teisteren. Terwijl hij de daders achtervolgt, ontdekt hij een sinister complot dat diep geworteld is in de corruptie van Gotham. Tijdens zijn zoektocht naar gerechtigheid komt Batman oog in oog te staan met enkele van zijn meest beruchte vijanden, waaronder de mysterieuze Riddler, gespeeld door Paul Dano. Het verhaal onthult de complexe psychologie van Bruce Wayne en onderzoekt zijn strijd met zijn eigen demonen terwijl hij de rol van beschermer van Gotham op zich neemt. The Batman belooft een donkere en grimmige reis te zijn, gevuld met spanning, actie en een diepgaande verkenning van het legendarische personage.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/mqqft2x_Aa4", "https://www.onthisday.com/images/people/robert-pattinson.jpg?w=360", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Zoe_Kravitz_2020_dvna_studio.jpg/800px-Zoe_Kravitz_2020_dvna_studio.jpg", "https://upload.wikimedia.org/wikipedia/commons/8/87/Paul_Dano_Cannes_2015.jpg", "Robert Pattinson", "Zoë Kravitz", "Paul Dano") },
            { "Jason Bourne", new Film("Jason Bourne","https://live-production.wcms.abc-cdn.net.au/ba22ded4dba30b5afe7f1a59174d794f?impolicy=wcms_crop_resize&cropH=364&cropW=647&xPos=0&yPos=0&width=862&height=485", "The Bourne Identity is een spannende actiethriller gebaseerd op de roman van Robert Ludlum. Het verhaal volgt Jason Bourne, een man die wordt gered uit de Middellandse Zee met twee kogels in zijn rug en aan geheugenverlies lijdt. Terwijl Bourne zijn identiteit probeert te achterhalen, ontdekt hij dat hij een hoogopgeleide geheim agent is met buitengewone vaardigheden. Hij wordt achtervolgd door meedogenloze CIA-agenten en moet ontsnappen aan hun dodelijke klopjacht. Met behulp van een mysterieuze vrouw, Marie, begint Bourne aan een gevaarlijke reis door Europa om de waarheid over zijn verleden te ontdekken en te vechten tegen degenen die hem willen elimineren. Het verhaal zit boordevol actie, spanning en onverwachte wendingen, terwijl Bourne vecht om zijn ware identiteit te onthullen en degenen die hem hebben verraden te confronteren. The Bourne Identity is een meeslepende en adrenaline-pompende film die de kijker op het puntje van hun stoel houdt.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/F4gJsKZvqE4", "https://m.media-amazon.com/images/M/MV5BMTM0NzYzNDgxMl5BMl5BanBnXkFtZTcwMDg2MTMyMw@@._V1_FMjpg_UX1000_.jpg", "https://m.media-amazon.com/images/M/MV5BMTgxNjUxNDk3MF5BMl5BanBnXkFtZTcwMzM0NjA0NA@@._V1_.jpg", "https://upload.wikimedia.org/wikipedia/commons/2/2d/Brian_Cox_%282016%29_-_01.jpg", "Matt Damon", "Julia Stiles", "Brian Cox") },
            { "Uncharted", new Film("Uncharted","https://m.media-amazon.com/images/M/MV5BM2QxZTY0NjctZmZhMy00ZWI3LTliNTAtMjQ4MGM5OTNiMTAyXkEyXkFqcGdeQXZ3ZXNsZXk@._V1_.jpg", "Uncharted is een avontuurlijke actiefilm gebaseerd op de gelijknamige populaire videogame-franchise. Het verhaal volgt Nathan Drake, een charismatische schattenjager en avonturier, gespeeld door Tom Holland. Nathan gaat op zoek naar de legendarische verloren schat van El Dorado. Tijdens zijn zoektocht moet Nathan obstakels overwinnen, gevaarlijke vijanden verslaan en mysteries ontrafelen die hem leiden naar exotische locaties over de hele wereld. Hij wordt bijgestaan door zijn mentor, Victor Sullivan, en raakt verwikkeld in een web van intrige en bedrog. Het verhaal is een spannende mix van actie, humor en ontdekkingen, waarbij Nathan zichzelf zowel fysiek als mentaal op de proef moet stellen. Hij moet zijn vaardigheden als avonturier en zijn scherpzinnigheid gebruiken om de schat te vinden en te voorkomen dat het in verkeerde handen valt. Uncharted is een adrenaline-pompend avontuur dat fans van de game en nieuwe kijkers zal meeslepen in een wereld vol geheimen, gevaar en ontzagwekkende ontdekkingen.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/eHp3MbsCbMg", "https://fwcdn.pl/ppo/92/11/1619211/450788.3.jpg", "https://m.media-amazon.com/images/M/MV5BMTU0MTQ4OTMyMV5BMl5BanBnXkFtZTcwMTQxOTY1NA@@._V1_.jpg", "https://flxt.tmsimg.com/assets/609607_v9_bb.jpg", "Tom Holland", "Mark Wahlberg", "Sophia Ali") },
            { "Ready Player One", new Film("Ready Player One","https://www.denofgeek.com/wp-content/uploads/2020/11/webstory-rpt-movie-12.jpg?fit=2600%2C1625", "Ready Player One is een dystopische sciencefictionfilm gebaseerd op de gelijknamige roman van Ernest Cline. Het verhaal speelt zich af in de nabije toekomst, waar de meeste mensen ontsnappen aan de harde realiteit door middel van een virtual reality-wereld genaamd de OASIS. Het verhaal volgt Wade Watts, een jonge avonturier die zich in de OASIS waagt op zoek naar een verborgen schat genaamd de Easter Egg. Het vinden van het Easter Egg zou niet alleen de erfenis van de OASIS-ontwikkelaar James Halliday ontsluiten, maar ook de controle over de virtuele wereld. Wade wordt geconfronteerd met talloze uitdagingen, puzzels en vijanden, terwijl hij vriendschappen sluit en bondgenoten vindt in de virtuele en echte wereld. Hij moet zijn kennis van popcultuur en zijn slimheid gebruiken om de schat te vinden en te voorkomen dat de hebzuchtige IOI Corporation de OASIS overneemt. Ready Player One is een spannend avontuur dat liefhebbers van games, films en popcultuur zal aanspreken. Het onderzoekt thema's van vriendschap, ontsnapping aan de realiteit en de kracht van samenwerking, allemaal verpakt in een visueel verbluffende en nostalgische wereld.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/cSp1dM2Vj48", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Tye_Sheridan_by_Gage_Skidmore_%28cropped%29.jpg/220px-Tye_Sheridan_by_Gage_Skidmore_%28cropped%29.jpg", "https://upload.wikimedia.org/wikipedia/commons/d/d8/Olivia_Cooke_by_Gage_Skidmore_2.jpg", "https://upload.wikimedia.org/wikipedia/commons/b/bc/Simon_Pegg_Premiere_of_Kill_Me_Three_Times_%28cropped%29.jpg", "Tye Sheridan", "Olivia Cooke", "Simon Pegg") },
            { "Gran Turismo", new Film("Gran Turismo","https://live.staticflickr.com/65535/52861954591_4516d2e3a9_5k.jpg", "Op dit moment is er geen concrete informatie beschikbaar over een specifieke verhaallijn voor de aankomende Gran Turismo film. Het is belangrijk op te merken dat Gran Turismo voornamelijk bekend staat om zijn focus op realistische racesimulatie in de videogameserie. Het is echter mogelijk dat de film zich zal concentreren op een hoofdpersonage, misschien een ambitieuze jonge autocoureur, die de wereld van het professionele racen wil veroveren. De film zou kunnen draaien om zijn/haar reis naar succes, het overwinnen van uitdagingen en rivaliteit, en uiteindelijk het behalen van de ultieme triomf in de racewereld. Hoewel er nog geen specifieke verhaallijn bekend is, kunnen we verwachten dat de Gran Turismo film de opwinding en het spektakel van autoracen op het grote scherm zal brengen, met adembenemende races, intense competitie en mogelijk een inspirerend verhaal van doorzettingsvermogen en passie voor de autosport.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Kijkwijzer_6.svg/640px-Kijkwijzer_6.svg.png", "https://www.youtube.com/embed/GVPzGBvPrzw", "https://m.media-amazon.com/images/M/MV5BOWE3M2ViODctMmJlNC00ZTJmLWEzZjYtZjNmMDg5NGY0YTViXkEyXkFqcGdeQXVyNTAyNDMwNTk@._V1_.jpg", "https://m.media-amazon.com/images/M/MV5BZTc5ODUzMDAtZGFhZS00NmExLTlhYWYtZDY0NGI2MGMwYTIzXkEyXkFqcGdeQXVyODY0MzQyODc@._V1_.jpg", "https://upload.wikimedia.org/wikipedia/commons/8/81/Orlando_Bloom_Cannes_2013.jpg", "Archie Madekwe", "David Harbour", "Orlando Bloom") },
            { "Indiana Jones", new Film("Indiana Jones","https://hips.hearstapps.com/vidthumb/images/indiana-jones-and-the-dial-of-destiny-trailer-6430255bade1d.jpg", "Als het gaat om de verhaallijn van Indiana Jones 5, zijn er op dit moment nog geen specifieke details bekend. De film, geregisseerd door James Mangold, staat gepland voor release in 2023. Gezien de voorgaande films in de franchise, kunnen we verwachten dat Indiana Jones, gespeeld door Harrison Ford, je weer meeneemt op een avontuurlijke reis vol spanning, actie en ontdekkingen. Het verhaal zou kunnen draaien om een nieuw artefact of een mysterie dat Indy moet ontrafelen, mogelijk met historische en mythische referenties. Met zijn kenmerkende zweep, fedora en avontuurlijke geest, zal Indiana Jones waarschijnlijk geconfronteerd worden met gevaarlijke situaties, vijanden en intrige terwijl hij vecht om het artefact te vinden en het uit verkeerde handen te houden. Hoewel er nog geen specifieke details zijn, kunnen fans van de franchise uitkijken naar een episch en nostalgisch avontuur in Indiana Jones 5.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Kijkwijzer_16.svg/1024px-Kijkwijzer_16.svg.png", "https://www.youtube.com/embed/eQfMbSe7F2g", "https://upload.wikimedia.org/wikipedia/commons/3/34/Harrison_Ford_by_Gage_Skidmore_3.jpg", "https://upload.wikimedia.org/wikipedia/commons/f/f2/Mads_Mikkelsen_Cannes_2013_2.jpg", "https://flxt.tmsimg.com/assets/644496_v9_bc.jpg", "Harrison Ford", "Mads Mikkelsen", "Phoebe Waller-Bridge") },
            { "The tourist", new Film("The Tourist","https://m.media-amazon.com/images/M/MV5BMTg1Nzg0MDE5OF5BMl5BanBnXkFtZTcwNTM1MjcxNA@@._V1_.jpg", "The Tourist is een spannende actiethriller die zich afspeelt in het prachtige decor van Venetië. Het verhaal draait om Frank Tupelo, een Amerikaanse toerist gespeeld door Johnny Depp, die tijdens zijn vakantie onverwachts verstrikt raakt in een gevaarlijk web van intrige en bedrog. Wanneer Frank de mysterieuze Elise, gespeeld door Angelina Jolie, ontmoet, wordt hij per ongeluk betrokken bij een internationale klopjacht. Hij wordt geconfronteerd met gevaarlijke criminelen, dubbelagenten en de geheime diensten van verschillende landen. Terwijl Frank en Elise door de smalle straten van Venetië vluchten, ontvouwt zich een intrigerend kat-en-muisspel. Frank moet zijn slimheid en moed gebruiken om te overleven en de waarheid achter de samenzwering te achterhalen. The Tourist biedt een mix van actie, spanning en romantiek, met adembenemende achtervolgingen en onverwachte wendingen. Het verhaal laat de kijker op het puntje van hun stoel zitten terwijl ze samen met de personages door de betoverende straten van Venetië dwalen en proberen te ontsnappen aan hun achtervolgers.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Kijkwijzer_12.svg/1024px-Kijkwijzer_12.svg.png", "https://www.youtube.com/embed/sSeLuNtOZaA", "https://m.media-amazon.com/images/M/MV5BODg3MzYwMjE4N15BMl5BanBnXkFtZTcwMjU5NzAzNw@@._V1_.jpg", "https://m.media-amazon.com/images/M/MV5BOTBhMTI1NDQtYmU4Mi00MjYyLTk5MjEtZjllMDkxOWY3ZGRhXkEyXkFqcGdeQXVyNzI1NzMxNzM@._V1_FMjpg_UX1000_.jpg", "https://flxt.tmsimg.com/assets/149859_v9_bc.jpg", "Angelina Jolie", "Johnny Depp", "Paul Bettany") },
       };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Films")]
        public IActionResult Films()
        {
            return View();
        }

        public IActionResult Ticket()
        {
            return View();
        }

        [Route("Succes")]
        public IActionResult Succes()
        {
            return View();
        }

        [Route("Detail")]
        public IActionResult Detail(string filmName)
        {
            return View(database[filmName]);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Person person)
        {
            if (ModelState.IsValid)
                return Redirect("/succes");

            return View(person);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Contact/Error");
            }
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/Contact";
                    await next();
                }
            });
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Contact}/{action=Index}/{id?}");
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

public static class MvcExtensions
{
    public static string ActiveClass(this IHtmlHelper htmlHelper, string controllers = null, string actions = null, string cssClass = "active")
    {
        var currentController = htmlHelper?.ViewContext.RouteData.Values["controller"] as string;
        var currentAction = htmlHelper?.ViewContext.RouteData.Values["action"] as string;

        var acceptedControllers = (controllers ?? currentController ?? "").Split(',');
        var acceptedActions = (actions ?? currentAction ?? "").Split(',');

        return acceptedControllers.Contains(currentController) && acceptedActions.Contains(currentAction)
            ? cssClass
            : "";
    }
}