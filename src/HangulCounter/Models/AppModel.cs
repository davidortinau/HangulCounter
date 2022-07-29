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
            new Counter{ LabelEnglish = "Years", LabelKorean = "년", Icon = "years.png" },
            new Counter{ LabelEnglish = "Shoes", LabelKorean = "켤레", Icon = "shoes.png" },
            new Counter{ LabelEnglish = "Trees", LabelKorean = "그루", Icon = "trees.png" },
            new Counter{ LabelEnglish = "Places", LabelKorean = "군데", Icon = "places.png"},
            new Counter{ LabelEnglish = "Floors", LabelKorean = "층", Icon = "floors.png"},
            new Counter{ LabelEnglish = "Won", LabelKorean = "원", Icon = "won.png"},
            new Counter{ LabelEnglish = "Age", LabelKorean = "살", Icon = "age.png"},
            new Counter{ LabelEnglish = "Kinds", LabelKorean = "가지", Icon = "kinds.png"},
            new Counter{ LabelEnglish = "Hours Duration", LabelKorean = "시간", Icon = "hours.png"},
            new Counter{ LabelEnglish = "Bowls", LabelKorean = "그릇", Icon = "bowls.png"}
        };

        // Game questions/prompts
        // 몇 살이에요? How old are you?
        // 몇 년생이에요? When were you born?
        // 서른 살이에요. I'm 30 years old.

    }
}

