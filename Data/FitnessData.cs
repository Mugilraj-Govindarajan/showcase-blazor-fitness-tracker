namespace FitnessTracker.Data
{
    public class ProfileInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Goal { get; set; }
        public string Email { get; set; }
        public string WeightMes { get; set; }
        public string GoalMes { get; set; }
        public string HeightMes { get; set; }
    }

    public class Activity
    {
        public string Name { get; set; }
        public string ActivityType { get; set; }
        public string Duration { get; set; }
        public int Count { get; set; }
        public string Amount { get; set; }
        public string Distance { get; set; }
        public string Percentage { get; set; }
        public string Time { get; set; }
    }

    public class ChartData
    {
        public DateTime X { get; set; }
        public double Y { get; set; }
    }
    public class GridListData
    {
        public string Workout { get; set; }
        public double Distance { get; set; }
        public double Duration { get; set; }
        public DateTime Date { get; set; }
        public double Completion { get; set; }
    }

    public class PieChartData
    {
        public string X { get; set; }
        public double Y { get; set; }
        public string Fill { get; set; }
    }

    public class MenuItems
    {
        public string Item { get; set; }
        public int Cal { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Proteins { get; set; }
        public double Sodium { get; set; }
        public double Iron { get; set; }
        public double Calcium { get; set; }
        public bool IsAdded { get; set; }
    }

    public class ActivitiesData
    {
        public int HeartRate { get; set; } = 80;
        public int Steps { get; set; } = 1240;
        public int SleepInMinutes { get; set; } = 350;
        public List<GridListData> GridData { get; set; } = new List<GridListData>();
        public List<ChartData> ChartData { get; set; }
        public List<ChartData> ChartDietData { get; set; }
        public int MorningWalk { get; set; }
        public List<ChartData> ActivityChartMonthData { get; set; }
        public List<ChartData> ActivityChartWeekData { get; set; }
    }

    public class DietData
    {
        public List<MenuItems> CurrentBreakFastMenu { get; set; }
        public List<MenuItems> CurrentSnack1Menu { get; set; }
        public List<MenuItems> CurrentLunchMenu { get; set; }
        public List<MenuItems> CurrentSnack2Menu { get; set; }
        public List<MenuItems> CurrentDinnerMenu { get; set; }
        public int CurrentBreakFastCalories { get; set; }
        public string CurrentBreakFastMenuText { get; set; }
        public bool IsBreakFastMenuAdded { get; set; }
        public int CurrentSnack1Calories { get; set; }
        public string CurrentSnack1MenuText { get; set; }
        public bool IsSnack1MenuAdded { get; set; }
        public int CurrentLunchCalories { get; set; }
        public bool IsLunchMenuAdded { get; set; }
        public string CurrentLunchMenuText { get; set; }
        public int CurrentSnack2Calories { get; set; }
        public bool IsSnack2MenuAdded { get; set; }
        public string CurrentSnack2MenuText { get; set; }
        public int CurrentDinnerCalories { get; set; }
        public bool IsDinnerMenuAdded { get; set; }
        public string CurrentDinnerMenuText { get; set; }
        public int ConsumedCalories { get; set; }
        public int BurnedCalories { get; set; }
        public int BreakfastWaterTaken { get; set; }
        public int LunchWaterTaken { get; set; }
        public double CurrentTotalProteins { get; set; }
        public double CurrentTotalFat { get; set; }
        public double CurrentTotalCarbs { get; set; }
        public double CurrentTotalCalcium { get; set; }
        public double CurrentTotalIron { get; set; }
        public double CurrentTotalSodium { get; set; }
    }

    public class FastingData
    {
        public int ConsumedWaterCount { get; set; } = 4;
        public int ConsumedWaterAmount { get; set; } = 600;
        public int ExpectedWaterAmount { get; set; } = 2400;
        public List<ChartData> WeightChartData { get; set; }
    }
}