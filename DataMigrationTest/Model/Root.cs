namespace DataMigrationTest.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class StatusInfo
    {
        public string? StatusDisplay { get; set; }
        public string? StatusLine3 { get; set; }
        public int SecondsSinceStart { get; set; }
    }

    public class ProgressInfo
    {
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public int AcceptedValue { get; set; }
        public int RejectedValue { get; set; }
        public int HwErrorsValue { get; set; }
    }

    public class SpeedInfo
    {
        public int LogInterval { get; set; }
        public string? Hashrate { get; set; }
        public long? HashrateValue { get; set; }
        public string? AvgHashrate { get; set; }
        public long AvgHashrateValue { get; set; }
        public string? WorkUtility { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
    }

    public class CoinInfo
    {
        public string? DisplayName { get; set; }
        public string? ShortName { get; set; }
        public string? RevenuePerDay { get; set; }
        public double RevenuePerDayValueDisplayCurrency { get; set; }
        public double RevenuePerDayValue { get; set; }
        public double RevenuePerDayValueBtc { get; set; }
        public string? RevenuePerMonth { get; set; }
        public double ProfitPerDayValue { get; set; }
        public double ProfitPerDayValueBtc { get; set; }
        public string? ProfitPerDay { get; set; }
        public string? ProfitPerMonth { get; set; }
        public int PowerUsageValue { get; set; }
        public bool IsActualPowerUsage { get; set; }
        public string? Algorithm { get; set; }
        public string? CoinClass { get; set; }
    }

    public class PoolList
    {
    }

    public class AsicList
    {
    }

    public class Root
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Hostname { get; set; }
        public string? HostDescription { get; set; }
        public int GroupID { get; set; }
        public string? Pool { get; set; }
        public string? Temperature { get; set; }
        public string? Hardware { get; set; }
        public string? SoftwareType { get; set; }
        public string? MacAddress { get; set; }
        public StatusInfo? StatusInfo { get; set; }
        public ProgressInfo? ProgressInfo { get; set; }
        public SpeedInfo? SpeedInfo { get; set; }
        public CoinInfo? CoinInfo { get; set; }
        public int MaxTemperatureValue { get; set; }
        public int AvgTemperatureValue { get; set; }
        public bool IsRunning { get; set; }
        public bool IsOffline { get; set; }
        public DateTime UpdatedUtc { get; set; }
        public string? Updated { get; set; }
        public List<PoolList>? PoolList { get; set; }
        public List<object>? GpuList { get; set; }
        public List<object>? PgaList { get; set; }
        public List<AsicList>? AsicList { get; set; }
        public List<object>? CpuList { get; set; }
        public bool HasPool { get; set; }
        public bool HasGpu { get; set; }
        public bool HasPga { get; set; }
        public bool HasAsic { get; set; }
        public bool HasCpu { get; set; }
        public bool CanReboot { get; set; }
        public bool CanStop { get; set; }
        public bool CanRestart { get; set; }
        public bool CanStart { get; set; }
        public bool CanPool { get; set; }
        public bool CanPoolSwitch { get; set; }
        public bool CanPoolSave { get; set; }
        public bool HasValidStatus { get; set; }
        public bool HasFirmwareLicense { get; set; }
    }


}
