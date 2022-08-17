using System;
namespace HangulCounter.Models
{
	public static class AppModel
	{
		public static List<Counter> Counters { get; set; } = new List<Counter>
		{
            new Counter{ LabelEnglish = "Animals", LabelKorean = "마리", Icon = "animals.png", IsNative = true },
            new Counter{ LabelEnglish = "Books", LabelKorean = "권", Icon = "books.png", IsNative = true },
            new Counter{ LabelEnglish = "Bottles", LabelKorean = "병", Icon = "bottle.png", IsNative= true },
            new Counter{ LabelEnglish = "Cars", LabelKorean = "대", Icon = "cars.png", IsNative = true },
            new Counter{ LabelEnglish = "Clothing", LabelKorean = "벌", Icon = "clothing.png", IsNative = true },
            new Counter{ LabelEnglish = "Days", LabelKorean = "일", Icon = "days.png" },
            new Counter{ LabelEnglish = "Hours", LabelKorean = "시간", Icon = "hour.png", IsNative = true },
            new Counter{ LabelEnglish = "Houses", LabelKorean = "채", Icon = "house.png", IsNative = true },
            new Counter{ LabelEnglish = "Minutes", LabelKorean = "분", Icon = "minute.png" },
            new Counter{ LabelEnglish = "Months", LabelKorean = "월", Icon = "months.png" },
            new Counter{ LabelEnglish = "People", LabelKorean = "명", Icon = "people.png", IsNative = true },
            new Counter{ LabelEnglish = "Slices", LabelKorean = "조각", Icon = "slices.png", IsNative = true },
            new Counter{ LabelEnglish = "Things", LabelKorean = "개", Icon = "things.png", IsNative = true },
            new Counter{ LabelEnglish = "Weeks", LabelKorean = "주일", Icon = "weeks.png" },
            new Counter{ LabelEnglish = "Years", LabelKorean = "년", Icon = "years.png" },
            new Counter{ LabelEnglish = "Shoes", LabelKorean = "켤레", Icon = "shoes.png", IsNative = true },
            new Counter{ LabelEnglish = "Trees", LabelKorean = "그루", Icon = "trees.png", IsNative = true },
            new Counter{ LabelEnglish = "Floors", LabelKorean = "층", Icon = "floors.png"},
            new Counter{ LabelEnglish = "Won", LabelKorean = "원", Icon = "won.png"},
            new Counter{ LabelEnglish = "Age", LabelKorean = "살", Icon = "age.png", IsNative = true },
            new Counter{ LabelEnglish = "Kinds", LabelKorean = "가지", Icon = "kinds.png", IsNative = true },
            new Counter{ LabelEnglish = "Hours Duration", LabelKorean = "시간", Icon = "hours.png", IsNative = true },
            new Counter{ LabelEnglish = "Bowls", LabelKorean = "그릇", Icon = "bowls.png", IsNative = true },
            new Counter{ LabelEnglish = "Cups", LabelKorean = "잔", Icon = "cup.png", IsNative = true },
            new Counter{ LabelEnglish = "Thin flat objects", LabelKorean = "장", Icon = "thin_object.png", IsNative = true },
            new Counter{ LabelEnglish = "Things arranged in lines", LabelKorean = "줄", Icon = "lines.png", IsNative = true},
            new Counter{ LabelEnglish = "Places", LabelKorean = "곳", Icon = "places.png", IsNative = true},
            new Counter{ LabelEnglish = "Measure of weight", LabelKorean = "그램", Icon = "weight.png" },
            new Counter{ LabelEnglish = "Nights spent away", LabelKorean = "박", Icon = "nights_away.png"},
            new Counter { LabelEnglish = "Pills", LabelKorean = "알", Icon = "round_small.png", IsNative = true },
            new Counter { LabelEnglish = "Portions", LabelKorean = "인분", Icon = "portion.png" },
            new Counter { LabelEnglish = "Bites of food", LabelKorean = "입", Icon = "bite.png", IsNative = true }
        };

        public static readonly Dictionary<long, string> NativeNumbers = new Dictionary<long, string>
        {
            {0, "" },
            {1, ""},
            {2, "두"},
            {3, "세"},
            {4, "네"},
            {5, "다섯"},
            {6, "여섯"},
            {7, "일곱"},
            {8, "여덟"},
            {9, "아홉"},
            {10, "열"},
            {11, "열한"},
            {12, "열두"},
            {13, "열세"},
            {14, "열네"},
            {15, "열다섯"},
            {16, "열여섯"},
            {17, "열일곱"},
            {18, "열여덟"},
            {19, "열아홉"},
            {20, "스물"},
            {30, "서른"},
            {40, "마흔"},
            {50, "쉰"},
            {60, "예순"},
            {70, "일흔"},
            {80, "여든"},
            {90, "아흔"}
        };

        public static string ToNative(int num)
        {
            if(num < 20)
            {
                return NativeNumbers[num];
            }
            else
            {
                var tens = GetPlace(num, 10);
                var ones = GetPlace(num, 1);
                return $"{NativeNumbers[tens]}{NativeNumbers[ones]}";
            }
        }

        public static int GetPlace(int value, int place)
        {
            return (value % (place * 10)) - (value % place);
        }

        // Game questions/prompts
        // 몇 살이에요? How old are you?
        // 몇 년생이에요? When were you born?
        // 서른 살이에요. I'm 30 years old.

    }
}

