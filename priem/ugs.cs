	public enum LevelEnum : int { spo = 1, bach = 2, mag = 3, aspira = 4 }
	public enum FormEnum : int { och = 1, ochzaoch = 2, zaoch = 3 }


	public class GroupItem
	{
		public string Code { get; set; } // код группы (12.34.00)
		public string Title { get; set; } // наименование группы
		public string Level { get; set; } // указатель на уровень образования (1=спо;2=бакалавриат/специалитет;3=магистратура;4=аспирантура)
		public string Form { get; set; } // форма обучения (1=очное;2=очнозаочное;3=заочное)
		public int Budget { get; set; } // количество бюджетных мест
		public int BudgetR { get; set; } // количество бюджетных мест (региональный, только СПО)
		public int Paid { get; set; } // количество контрактных мест
		public int Target { get; set; } // количество целевых мест
		public int Quota { get; set; } // количество льготных мест
		public int Price { get; set; } // стоимость обучения
		public string Discount { get; set; } // информация о скидках (текст)
		public string Comment { get; set; } // комментарий
		public List<DirectionItem> Directions { get; set; } // направления подготовки
		public List<TestItem> Tests { get; set; } // вступительные испытания

		// services
		public bool HasDirections => Directions != null && Directions.Any();
		public bool HasTests => Tests != null && Tests.Any();
	}


	public class DirectionItem
	{
		public string Code { get; set; } // код направления (12.34.56)
		public string Title { get; set; } // наименование направления
		public List<ProgramItem> Programs { get; set; } // образовательные программы

		// services
		public bool HasPrograms => Programs != null && Programs.Any();
	}


	public class ProgramItem
	{
		public string Code { get; set; } // код профиля (00 -> 12.34.56.[78])
		public string Title { get; set; } // наименование программы
		public string Qualification { get; set; } // присваиваемая квалификация
		public string Dep { get; set; } // институт/факультет
		public string Chair { get; set; } // выпускающая кафедра
		public string AisId { get; set; } // идентификатор программы в АИС // "eduplanLink": "", // ссылка на УП в раздел (???)
		public string Description { get; set; } // описание программы
		public string Video { get; set; } // рекламный ролик (id-видео)
		public string Uniqueness { get; set; } // уникальность (особеннось) программы
		public HeadItem Head { get; set; } // руководитель программы
		public List<ContactItem> Contacts { get; set; } // контакты
		public List<DocItem> Docs { get; set; } // разрешительные документы (лицензии, аккредитации)
		public List<OrgItem> Partners { get; set; } // индустриальные партнеры
		public List<MtoItem> Mtos { get; set; } // лаборатории, ресурсы (МТО) (сложно реализовать через АИС, оно вообще надо?)
		public PracticeItem Practice { get; set; } // договора о практике
		public List<SkillItem> Skills { get; set; } // навыки выпускника
		public List<ProfessionItem> Professions { get; set; } // профессии выпускника
		public CareerItem Career { get; set; } // карьера выпускника

		// services
		public bool HasContacts => Contacts != null && Contacts.Any();
		public bool HasDocs => Docs != null && Docs.Any();
		public bool HasPartners => Partners != null && Partners.Any();
		public bool HasMtos => Mtos != null && Mtos.Any();
		public bool HasSkills => Skills != null && Skills.Any();
		public bool HasProfessions => Professions != null && Professions.Any();
	}


	public class HeadItem
	{
		public int ProId { get; set; } // идентификатор из pro.guap.ru
		public string Fio { get; set; } // ФИО
		public string Photo { get; set; } // ссылка на фото
		public string Link { get; set; } // ссылка на страницу
		public string Post { get; set; } // должность в ГУАП
		public string Achievemants { get; set; } // достижения
	}


	public class ContactItem
	{
		public int ProId { get; set; } // идентификатор из pro.guap.ru
		public string Fio { get; set; } // ФИО
		public string Photo { get; set; } // ссылка на фото
		public string Post { get; set; } // должность
		public string Phone { get; set; } // телефон
		public string Email { get; set; } // адрес электронной почты
		public string[] Media { get; set; } // мессенджеры и социальные сети

		// services
		public bool HasMedia => Media != null && Media.Any();
	}


	public class DocItem
	{
		public string Type { get; set; } // тип документа
		public string Title { get; set; } // название документа
		public string Link { get; set; } // ссылка на скачивание
	}


	public class OrgItem
	{
		public string Title { get; set; } // наименование организации
		public string Description { get; set; } // описание
		public string Link { get; set; } // ссылка на сайт
	}


	public class MtoItem
	{
		public string Title { get; set; } // название лаборатории
		public string build { get; set; } // здание
		public string room { get; set; } // помещение
		public string photo { get; set; } // фото
		public string Description { get; set; } // описание лаборатории
	}


	public class PracticeItem
	{
		public string Description { get; set; } // описание практической подготовки
		public List<OrgItem> Orgs { get; set; } // организации по практической подготовке

		// services
		public bool HasOrgs => Orgs != null && Orgs.Any();
	}


	public class SkillItem
	{
		public string Title { get; set; } // название навыка
	}


	public class ProfessionItem
	{
		public string Title { get; set; } // название профессии
	}


	public class CareerItem
	{
		public string Description { get; set; } // описание возможной карьеры
		public string NextEdu { get; set; } // направления для продолжения обучения
		public List<OrgItem> Orgs { get; set; } // потенциальные работодатели

		// services
		public bool HasOrgs => Orgs != null && Orgs.Any();
	}


	public class TestItem
	{
		public int Priority { get; set; } // приоритет вступительного испытания
		[Newtonsoft.Json.JsonProperty("subject")]
		public List<SubjectItem> Subjects { get; set; } // предметы вступительного испытания

		// services
		public bool HasSubjects => Subjects != null && Subjects.Any();
	}


	public class SubjectItem
	{
		public string Title { get; set; } // наименование предмета
		public int Min { get; set; } // минимальный балл
		public string Link { get; set; } // ссылка на программу вступительного испытания
		public string Comment { get; set; } // комментарий
	}