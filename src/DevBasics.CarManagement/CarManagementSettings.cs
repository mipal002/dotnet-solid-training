using System.Collections.Generic;

namespace DevBasics.CarManagement
{
    public class CarManagementSettings
    {
        public IDictionary<string, string> HttpHeaders { get; set; } = new Dictionary<string, string>();

        public CarManagementSettings()
        {
            // Define headers for HTTP-Requests.
            HttpHeaders.Add("Content-Type", "application/json");
        }
    }

//AM BESTEN ALS conf File bereitstellen statt im Code zu definieren!

public static class TimeZoneSettings {

    public static IDictionary<string, int> TimeZones { get; set; } = new Dictionary<string, int>() {
        {"Europe/London", 0},
        {"Europe/Lisbon", 0},
        {"America/Noronha", 120},
        {"Atlantic/South_Georgia", 1},
        {"America/Argentina/Buenos_Aires", 180},
        {"America/Sao_Paulo", 180},
        {"America/Godthab", 180},
        {"America/St_Johns", 210},
        {"America/Halifax", 240},
        {"America/Aruba", 240},
        {"America/New_York", 300},
        {"EST", 300},
        {"America/Chicago", 360},
        {"America/Mexico_City", 360},
        {"America/Phoenix", 420},
        {"America/Santa_Isabel", 480},
        {"America/Vancouver", 480},
        {"America/Los_Angeles", 480},
        {"America/Anchorage", 540},
        {"America/Yakutat", 540},
        {"Pacific/Honolulu", 600},
        {"Europe/Berlin", -60},
        {"Europe/Bratislava", -60},
        {"Europe/Bucharest", -120},
        {"Europe/Istanbul", -120},
        {"Asia/Kuwait", -180},
        {"Asia/Muscat", -240},
        {"Asia/Oral", -300},
        {"Asia/Yekaterinburg", -300},
        {"Asia/Kolkata", -330},
        {"Asia/Omsk", -360},
        {"Indian/Cocos", -390},
        {"Asia/Pontianak", -420},
        {"Asia/Bangkok", -420},
        {"Asia/Singapore", -480},
        {"Asia/Kuala_Lumpur", -480},
        {"Australia/Perth", -480},
        {"Asia/Shanghai", -480},
        {"Asia/Tokyo", -540},
        {"Asia/Seoul", -540},
        {"Australia/Adelaide", -570},
        {"Australia/Melbourne", -600},
        {"Australia/Lord_Howe", -630},
        {"Etc/GMT-11", -660},
        {"Pacific/Auckland", -720},
        {"Etc/GMT-13", -780}
    };
}


public static class ApiEndpointsSettings {
    public static IDictionary<int, string> ApiEndpoints { get; set; } = new Dictionary<int, string>(){
        {1, "/bulk-registration-devices"},
        {2, "/check-transaction-status"},
        {3, "/show-registration-details"},
    };
}

public static class LanguageCodesSettings {
    public static IDictionary<string, string> LanguageCodes { get; set; } = new Dictionary<string, string>() {
        {"Dutch", "nl"},
        {"English", "en"},
        {"French", "fr"},
        {"German", "de"},
        {"Spanish", "es"},
        {"Italian", "it"},
        {"Japanese", "jp"},
        {"Traditional Chinese", "zf"},
        {"Simple Chinese", "zh"},
        {"Swedish", "sv"},
        {"Finnish", "fi"},
        {"Danish", "dk"},
        {"Norwegian", "no"},
        {"Thailand", "th"},
        {"Brazilian Portugese", "br"},
        {"Czech", "cs"},
        {"Hungarian", "hu"},
        {"Polish", "pl"},
        {"Portuguese", "pt"},
        {"Korean", "ko"},
        {"Malay", "my"},
        {"Romanian", "ro"},
        {"Slovak", "sk"},
        {"Ukrainian", "uk"},
        {"Hindi", "hi"},
    };
}
}