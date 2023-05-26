using OpenQA.Selenium;

namespace AuthorizationTests
{
    public class Tests
    {
        private IWebDriver driver;
        //вход
        private readonly By _btnEnter = By.XPath("//span[text()='Войти']");
        //другим способом
        private readonly By _btnAnotherWay = By.XPath("//span[text()='Другим способом']");
        //почта
        private readonly By _txtLoginInput = By.XPath("//input[@name='username']");
        private const string _login = "elvina.korshikova@mail.ru";
        //продолжить
        private readonly By _btnСontinue = By.XPath("//span[text()='Продолжить']");
        //пароль
        private readonly By _txtPasswordInput = By.XPath("//input[@name='password']");
        private readonly By _btnEnterSecond = By.XPath("//button[@data-name='ContinueAuthBtn']");
        private const string _password = "Elvina2001";
        //разместить объявление
        private readonly By _btnPalceAnAd = By.XPath("//span[text()='+ Разместить объявление']");
        //тип аккаунта
        private readonly By _btnOwner = By.XPath("//div[@data-mark='switcher_button||true']");
        //тип сделки
        private readonly By _btnRent = By.XPath("//div[@data-mark='switcher_button|adType.dealType|rent']");
        //тип аренды                   
        private readonly By _btnDailyRent = By.XPath("//div[@data-mark='switcher_button|adType.rentDuration|short']");
        //тип недвижимости
        private readonly By _btnFlat = By.XPath("//div[@data-mark='switcher_button|adType.objectType|flat']");
        //объект
        private readonly By _txtAddress = By.XPath("//input[@name='geo.userInput']");
        //адрес
        private const string _address = "Санкт-Петербург, посёлок Парголово, улица Шишкина, 303к1, подъезд 2";
        private readonly By _txtCadastralNumber = By.XPath("//input[@name='cadastralNumber']");
        //кадастровый номер
        private const string _cadastralNumber = "47:14:1203001:814";
        //тип жилья
        private readonly By _btnTypeOfHousing = By.XPath("//div[@data-mark='switcher_button|ad.housingType|false']");
        //кол-во комнат
        private readonly By _cmbNotSelected = By.XPath("//span[text()='Не выбрано']");
        private readonly By _liNumberOfRooms = By.XPath("//li[text()='3']");
        //общая площадь
        private readonly By _txtTotalArea = By.XPath("//input[@name='urbanTotalArea']");
        private const string _totalArea = "56";
        //картинка
        private readonly By _btnLayout = By.XPath("//span[text()='Загрузить планировку']");
        private const string _layout = "C:\\Эльвина\\VisualStudio\\second_img.jpg";
        //этаж
        private readonly By _txtWhichFloor = By.XPath("//input[@name='floorNumber']");
        private const string _whichFloor = "7";
        //площадь комнат
        private readonly By _txtRoomArea = By.XPath("//input[@name='allRoomsArea']");
        private const string _roomArea = "18-13-9";
        //кол-во спальных мест
        private readonly By _txtNumberOfBeds = By.XPath("//input[@name='bedsCount']"); 
        private const string _numberOfBeds = "5";
        //жилая площадь
        private readonly By _txtLivingArea = By.XPath("//input[@name='livingArea']"); 
        private const string _livingArea = "20";
        //кухня
        private readonly By _txtKitchen = By.XPath("//input[@name='kitchenArea']");
        private const string _kitchen = "17";
        //балкон
        private readonly By _btnBalcony = By.XPath("//div[@data-mark='switcher_button|ad.balconiesCount|1']");
        //окна выходят
        private readonly By _btnWindowsOverlook = By.XPath("//div[@data-mark='checkbox|windowViewType.street=false']");
        //разделенные санузлы
        private readonly By _btnSharedBathrooms = By.XPath("//data-mark='switcher_button|ad.separateWcsCount|1']");
        //ремонт
        private readonly By _btnRepair = By.XPath("//div[@data-mark='switcher_button|ad.repairType|design']");
        //в квартире
        private readonly By _a = By.XPath("//span[text()='Мебель в комнатах']");
        private readonly By _b = By.XPath("//span[text()='Мебель на кухне']");
        private readonly By _c = By.XPath("//span[text()='Холодильник']");
        private readonly By _d = By.XPath("//span[text()='Посудомоечная машина']");
        private readonly By _e = By.XPath("//span[text()='Стиральная машина']");
        private readonly By _f = By.XPath("//span[text()='Интернет']");
        private readonly By _g = By.XPath("//span[text()='Телевизор']");
        private readonly By _h = By.XPath("//span[text()='Душевая кабина']");
        //загрузка фотки
        private readonly By _imgFlat = By.XPath("//input[@name='photos']");
        private const string _flat = "C:\\Эльвина\\VisualStudio\\second_img.jpg";
        //видос
        private readonly By _YouTube = By.XPath("//input[@name='youtube']");
        private const string _video = "https://www.youtube.com/watch?v=RjFUVM2eek8";
        //добавить
        private readonly By _btnEnterThird = By.XPath("//span[text()='Добавить']");
        //описание
        private readonly By _txtDescription = By.TagName("textarea");
        private const string _description = "Владимир Александрович, поставьте пятеру автоматом)))))))))))";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver(); //открытие браузера
            driver.Navigate().GoToUrl("https://cian.ru"); //открытие сайта
            driver.Manage().Window.Maximize(); //открытие браузера на весь экран
        }

        [Test]
        public void Test1()
        {
            var btnEnter = driver.FindElement(_btnEnter);
            btnEnter.Click();

            var btnAnotherWay = driver.FindElement(_btnAnotherWay);
            btnAnotherWay.Click();

            var txtLoginInput = driver.FindElement(_txtLoginInput);
            txtLoginInput.SendKeys(_login);

            var btnСontinue = driver.FindElement(_btnСontinue);
            btnСontinue.Click();

            Thread.Sleep(2000);
            var txtPasswordInput = driver.FindElement(_txtPasswordInput);
            txtPasswordInput.SendKeys(_password);

            var btnEnterSecond = driver.FindElement(_btnEnterSecond);
            btnEnterSecond.Click();

            Thread.Sleep(5000);
            var btnPalceAnAd = driver.FindElement(_btnPalceAnAd);
            btnPalceAnAd.Click();

            var btnOwner = driver.FindElement(_btnOwner);
            btnOwner.Click();
            Thread.Sleep(2000);

            var btnRent = driver.FindElement(_btnRent);
            btnRent.Click();

            var btnDailyRent = driver.FindElement(_btnDailyRent);
            btnDailyRent.Click();

            Thread.Sleep(3000);
            var btnFlat = driver.FindElement(_btnFlat);
            btnFlat.Click();

            Thread.Sleep(3000);
            var txtAddress = driver.FindElement(_txtAddress);
            txtAddress.Clear();
            txtAddress.SendKeys(_address);

            var txtCadastralNumber = driver.FindElement(_txtCadastralNumber);
            txtCadastralNumber.SendKeys(_cadastralNumber);

            var btnTypeOfHousing = driver.FindElement(_btnTypeOfHousing);
            btnTypeOfHousing.Click();


            Thread.Sleep(2000);

            var cmbNotSelected = driver.FindElement(_cmbNotSelected);
            cmbNotSelected.Click();

            Thread.Sleep(7000);

            var liNumberOfRooms = driver.FindElement(_liNumberOfRooms);
            liNumberOfRooms.Click();

            var txtTotalArea = driver.FindElement(_txtTotalArea);
            txtTotalArea.SendKeys(_totalArea);

            var txtWhichFloor = driver.FindElement(_txtWhichFloor);
            txtWhichFloor.SendKeys(_whichFloor);

            var txtRoomArea = driver.FindElement(_txtRoomArea);
            txtRoomArea.SendKeys(_roomArea);

            var txtNumberOfBeds = driver.FindElement(_txtNumberOfBeds);
            txtNumberOfBeds.SendKeys(_numberOfBeds);

            var txtLivingArea = driver.FindElement(_txtLivingArea);
            txtLivingArea.SendKeys(_livingArea);

            var txtKitchen = driver.FindElement(_txtKitchen);
            txtKitchen.SendKeys(_kitchen);

            var btnRepair = driver.FindElement(_btnRepair);
            btnRepair.Click();

            var a = driver.FindElement(_a);
            a.Click();

            var b = driver.FindElement(_b);
            b.Click();

            var c = driver.FindElement(_c);
            c.Click();

            var d = driver.FindElement(_d);
            d.Click();

            var e = driver.FindElement(_e);
            e.Click();

            var f = driver.FindElement(_f);
            f.Click();

            var g = driver.FindElement(_g);
            g.Click();

            Thread.Sleep(5000);

            var imgFlat = driver.FindElement(_imgFlat);
            imgFlat.SendKeys(_flat);

            Thread.Sleep(2000);

            var youTube = driver.FindElement(_YouTube);
            youTube.SendKeys(_video);

            var btnEnterThird = driver.FindElement(_btnEnterThird);
            btnEnterThird.Click();

            var txtDescription = driver.FindElement(_txtDescription);
            txtDescription.SendKeys(_description);

            Assert.Pass();
        }
    }
}