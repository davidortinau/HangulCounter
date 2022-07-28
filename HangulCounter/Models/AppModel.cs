using System;
namespace HangulCounter.Models
{
	public static class AppModel
	{
		public static List<Counter> Counters { get; set; } = new List<Counter>
		{
            new Counter{ LabelEnglish = "Animals", LabelKorean = "마리", Icon = "animals.png" },
            new Counter{ LabelEnglish = "Books", LabelKorean = "권", Icon = "books.png" },
            new Counter{ LabelEnglish = "Bottles", LabelKorean = "병", Icon = "bottle.png" },
            new Counter{ LabelEnglish = "Cars", LabelKorean = "대", Icon = "cars.png" },
            new Counter{ LabelEnglish = "Clothing", LabelKorean = "벌", Icon = "clothing.png" },
            new Counter{ LabelEnglish = "Days", LabelKorean = "일", Icon = "days.png" },
            new Counter{ LabelEnglish = "Hours", LabelKorean = "시간", Icon = "hour.png" },
            new Counter{ LabelEnglish = "Houses", LabelKorean = "채", Icon = "house.png" },
            new Counter{ LabelEnglish = "Minutes", LabelKorean = "분", Icon = "minute.png" },
            new Counter{ LabelEnglish = "Months", LabelKorean = "월", Icon = "months.png" },
            new Counter{ LabelEnglish = "People", LabelKorean = "명", Icon = "people.png" },
            new Counter{ LabelEnglish = "Slices", LabelKorean = "조각", Icon = "slices.png" },
            new Counter{ LabelEnglish = "Things", LabelKorean = "개", Icon = "things.png" },
            new Counter{ LabelEnglish = "Weeks", LabelKorean = "주일", Icon = "weeks.png" },
            new Counter{ LabelEnglish = "Years", LabelKorean = "년", Icon = "years.png" }
        };
	}
}

