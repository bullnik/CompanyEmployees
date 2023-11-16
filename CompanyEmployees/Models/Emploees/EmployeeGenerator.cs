﻿using System;

namespace CompanyEmployees.Models.Emploees
{
    public class EmployeeGenerator : IGenerator<Employee>
    {
        private readonly string[] _maleLastNames = { "Воронов", "Корнилов", "Симонов", "Новиков", "Козлов", "Давыдов", "Суханов", "Александров ", "Алексеев", "Калугин", "Иванов", "Фетисов", "Родионов", "Смирнов", "Михайлов", "Кузнецов", "Федоров", "Щербаков", "Любимов", "Осипов", "Киселев", "Щукин", "Скворцов", "Петров", "Наумов", "Молчанов", "Макаров", "Хохлов", "Никитин", "Титов", "Чеботарев", "Семенов", "Литвинов", "Овчинников", "Никольский", "Владимиров", "Горбунов", "Леонов", "Яковлев", "Лобанов", "Потапов", "Данилов", "Корнев", "Ковалев", "Малышев", "Ершов", "Кузьмин", "Антонов", "Лазарев", "Муратов", "Гаврилов", "Захаров", "Кочетков", "Попов", "Самойлов", "Соколов", "Сидоров", "Игнатов", "Назаров", "Громов", "Зайцев", "Киреев", "Морозов", "Денисов", "Егоров", "Софронов", "Мальцев", "Колесов", "Ковалев ", "Вавилов", "Миронов", "Стариков", "Жуков", "Львов", "Николаев", "Кочергин", "Емельянов", "Калашников", "Лукьянов", "Максимов", "Аксенов", "Еремин", "Кондрашов", "Матвеев", "Платонов", "Черкасов", "Кондратов", "Елизаров", "Фролов", "Комаров", "Фомин", "Карпов", "Круглов", "Сергеев", "Зубов", "Зверев", "Беляев", "Большаков", "Голованов", "Мельников", "Калинин", "Ермаков", "Токарев", "Мещеряков", "Герасимов", "Субботин", "Куприянов", "Панов", "Рябов", "Романов", "Баранов", "Марков", "Ларионов", "Коновалов", "Голубев", "Ульянов", "Широков", "Дьяков", "Жданов", "Григорьев", "Мартынов", "Безруков", "Дмитриев", "Сорокин", "Никифоров", "Волошин", "Климов", "Тимофеев", "Селиванов", "Зотов", "Князев", "Соловьев", "Еремеев", "Федотов", "Дружинин", "Орлов", "Терентьев", "Панков", "Евдокимов", "Павлов", "Сахаров", "Сальников", "Крылов", };
        private readonly string[] _maleFirstNames = { "Егор", "Степан", "Руслан", "Адам", "Максим", "Семён", "Николай", "Роман ", "Фёдор", "Даниил", "Артём", "Савелий", "Мирон", "Дмитрий", "Тимофей", "Евгений", "Никита", "Сергей", "Илья", "Богдан", "Алексей", "Андрей", "Ярослав", "Вячеслав", "Лев", "Данил", "Борис ", "Марк", "Иван", "Александр", "Елисей", "Владимир", "Кирилл", "Денис", "Станислав", "Павел", "Георгий", "Ян", "Захар", "Платон", "Денис ", "Савва", "Давид", "Макар", "Святослав", "Леонид", "Роман", "Эмир", "Михаил", "Гордей", "Константин", "Всеволод", "Артемий", "Демид", "Тимур", "Яков", "Марат", "Матвей", "Мирослав", "Игорь", "Анатолий", "Данила", "Эмиль", "Вадим", "Даниэль", };
        private readonly string[] _maleMiddleNames = { "Даниилович", "Андреевич", "Михайлович", "Константинович", "Алексеевич", "Ярославович", "Тимурович", "Лукич ", "Кириллович", "Дмитриевич", "Романович", "Максимович", "Маркович", "Артёмович", "Владиславович", "Ильич", "Савельевич", "Николаевич", "Львович", "Владимирович", "Александрович", "Данилович", "Глебович", "Егорович", "Сергеевич", "Всеволодович", "Иванович", "Дамирович", "Игоревич", "Павлович", "Давидович", "Семёнович", "Антонович", "Платонович", "Русланович", "Никитич", "Артемьевич", "Петрович", "Янович", "Юрьевич", "Тимофеевич", "Фёдорович", "Демидович", "Миронович", "Степанович", "Макарович", "Богданович", "Алиевич", "Ибрагимович", "Георгиевич", "Захарович", "Эмильевич", "Матвеевич", "Арсентьевич", "Робертович", "Демьянович", "Каримович", "Григорьевич", "Филиппович", "Леонидович", "Даниэльевич", "Борисович", "Эмирович", "Евгеньевич", "Анатольевич", };
        private readonly string[] _femaleLastNames = { "Смирнова", "Орлова", "Виноградова", "Потапова", "Некрасова", "Александрова", "Киселева", "Воронина", "Полякова", "Ковалева", "Петрова", "Львова", "Соколова", "Румянцева", "Иванова", "Гладкова", "Куликова", "Лебедева", "Антипова", "Лукьянова", "Елизарова", "Егорова", "Мальцева", "Комарова", "Лаптева", "Орехова", "Вишневская", "Царева", "Козлова", "Митрофанова", "Зеленина", "Русакова", "Карпова", "Захарова", "Волкова", "Васильева", "Зотова", "Кузнецова", "Бирюкова", "Малышева", "Белова", "Романова", "Емельянова", "Швецова", "Андреева", "Горшкова", "Сальникова", "Спиридонова", "Сорокина", "Зайцева", "Сафонова", "Коновалова", "Короткова", "Рыбакова", "Свиридова", "Миронова", "Колесникова", "Тихомирова", "Дмитриева", "Жарова", "Чеботарева", "Гришина", "Алешина", "Фомина", "Трифонова", "Исаева", "Михайлова", "Глухова", "Степанова", "Елисеева", "Игнатова", "Бородина", "Рудакова", "Блинова", "Николаева", "Воробьева", "Алексеева", "Тимофеева", "Семина", "Кузьмина", "Ерофеева", "Филиппова", "Карасева", "Попова", "Чеснокова", "Суханова", "Сергеева", "Абрамова", "Чернова", "Краснова", "Шмелева", "Власова", "Белоусова", "Прокофьева", "Антонова", "Агафонова", "Богданова", "Павлова", "Платонова", "Федорова", "Трофимова", "Дроздова", "Петухова", "Трошина", "Королева", "Яковлева", "Завьялова", "Чистякова", "Овсянникова", "Лапина", "Зорина", "Назарова", "Никитина", "Рябова", "Гусева", "Тарасова", "Муравьева", "Олейникова", "Денисова", "Крылова", "Гончарова", "Никонова", "Савельева", "Григорьева", "Березина", "Баранова", "Галкина", "Соловьева", "Жукова", "Боброва", "Семенова", "Кудрявцева", "Морозова", "Герасимова", "Акимова", "Уварова", "Ларина", };
        private readonly string[] _femaleFirstNames = { "Валерия", "Дарья", "Ирина", "Ева", "Мария", "Ника", "Таисия", "Вероника", "Алиса", "София", "Елизавета", "Анастасия", "Стефания", "Милана", "Агата", "Анна", "Алла", "Варвара", "Екатерина", "Арина", "Василиса", "Амира", "Алёна", "Амина", "Полина", "Александра", "Софья", "Марианна", "Есения", "Вера", "Ангелина", "Ксения", "Мелания", "Татьяна", "Лея", "Мирослава", "Марина", "Елена", "Кристина", "Маргарита", "Виктория", "Ульяна", "Наталья", "Мия", "Кира", "Оливия", "Надежда", "Алина", "Эмилия", "Нина", "Марьяна", "Евгения", "Аиша", "Любовь", "Марковн", "Ариана", "Алия", "Марта", "Белла", };
        private readonly string[] _femaleMiddleNames = { "Дмитриевна", "Ивановна", "Александровна", "Макаровна", "Михайловна", "Давидовна", "Данииловна", "Андреевна", "Георгиевна", "Ярославовна", "Ибрагимовна", "Вадимовна", "Максимовна", "Ильинична", "Евгеньевна", "Степановна", "Денисовна", "Леонидовна", "Мироновна", "Захаровна", "Никитична", "Руслановна", "Артёмовна", "Святославовна", "Даниловна", "Семёновна", "Платоновна", "Егоровна", "Тимофеевна", "Константиновна", "Станиславовна", "Алексеевна", "Глебовна", "Львовна", "Павловна", "Кирилловна", "Арсентьевна", "Вячеславовна", "Петровна", "Владимировна", "Романовна", "Марковна", "Маратовна", "Олеговна", "Григорьевна", "Германовна", "Демьяновна", "Артемьевна", "Алиевна", "Васильевна", "Матвеевна", "Николаевна", "Владиславовна", "Елисеевна", "Серафимовна", "Юрьевна", "Даниэльевна", "Фёдоровна", "Сергеевна", "Антоновна", "Родионовна", };
        private readonly int _postCount = Enum.GetNames(typeof(Post)).Length;
        private readonly Random _random = new();

        public IEnumerable<Employee> Generate(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return Generate();
            }
        }

        public Employee Generate()
        {
            Gender gender = _random.Next(2) == 0
                ? Gender.Male
                : Gender.Female;
            string lastName = gender == Gender.Male
                ? _maleLastNames[_random.Next(_maleLastNames.Length)]
                : _femaleLastNames[_random.Next(_femaleLastNames.Length)];
            string firstName = gender == Gender.Male
                ? _maleFirstNames[_random.Next(_maleFirstNames.Length)]
                : _femaleFirstNames[_random.Next(_femaleFirstNames.Length)];
            string middleName = gender == Gender.Male
                ? _maleMiddleNames[_random.Next(_maleMiddleNames.Length)]
                : _femaleMiddleNames[_random.Next(_femaleMiddleNames.Length)];
            Post post = (Post)_random.Next(_postCount);
            int age = _random.Next(20, 71);

            return new(firstName, lastName, middleName, gender, post, age);
        }
    }
}