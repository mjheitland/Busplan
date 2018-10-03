/*
 * Satzzeichen werden von Alexa nur erkannt, wenn dahinter ein Leerzeichen folgt!
 * Zum Debuggen in die Logdateien schauen (hier in VS unter Function/Logs Fenster)
 * 
 * Request object:
   {
    "version": "1.0",
    "session": {
        "new": true,
        "sessionId": "amzn1.echo-api.session.705f4739-e2d8-4d46-b2df-4fb37b1d9799",
        "attributes": null,
        "application": {
            "applicationId": "amzn1.ask.skill.400c6fef-a18f-44e8-aacb-5249b78214e0"
        },
        "user": {
            "userId": "amzn1.ask.account.AHNN62X4E7MJ4QDSNKHKUURSLPGYCABPJ65VZPXPMTNERCQUKPFTW6SKYVJSSO6DT3T4VZRP34SGSZTMX2WJNPR5NIJ6FVTWP2UE2ZEXE53WZSFJFHJSHM4DXIQJ6E3U4AYQCTS4JY436K3MJEECIBDDWMSAX5BCV2GR2YTHPWEG754Q3TNRLHUUY52C6GIRN7L2PETS7M5LA4A",
            "accessToken": null,
            "permissions": null
        }
    },
    "context": {
        "System": {
            "apiAccessToken": "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6IjEifQ.eyJhdWQiOiJodHRwczovL2FwaS5hbWF6b25hbGV4YS5jb20iLCJpc3MiOiJBbGV4YVNraWxsS2l0Iiwic3ViIjoiYW16bjEuYXNrLnNraWxsLjQwMGM2ZmVmLWExOGYtNDRlOC1hYWNiLTUyNDliNzgyMTRlMCIsImV4cCI6MTUzMTY0MDY0NywiaWF0IjoxNTMxNjM3MDQ3LCJuYmYiOjE1MzE2MzcwNDcsInByaXZhdGVDbGFpbXMiOnsiY29uc2VudFRva2VuIjpudWxsLCJkZXZpY2VJZCI6ImFtem4xLmFzay5kZXZpY2UuQUY3S1YzSTdNRldNWjJIMzVIV1VGUU9WWk5WR1NRWVZRUUZUUVpCT01ZQ1NPUTNONkhMRk4yM1BGUUxSVERDQ05EM0RCSUwzVlRaNUZXN0NWQVVWVzdQSzRFQkJUWjNMRlg2SDVZQVE1Nkc0VjdBRE1QSjI1V0tWQUdYUUNBM0ZTWUg1UUlJR1FXUTRaMllERElTRTVPR0lIRk5BIiwidXNlcklkIjoiYW16bjEuYXNrLmFjY291bnQuQUhOTjYyWDRFN01KNFFEU05LSEtVVVJTTFBHWUNBQlBKNjVWWlBYUE1UTkVSQ1FVS1BGVFc2U0tZVkpTU082RFQzVDRWWlJQMzRTR1NaVE1YMldKTlBSNU5JSjZGVlRXUDJVRTJaRVhFNTNXWlNGSkZISlNITTREWElRSjZFM1U0QVlRQ1RTNEpZNDM2SzNNSkVFQ0lCRERXTVNBWDVCQ1YyR1IyWVRIUFdFRzc1NFEzVE5STEhVVVk1MkM2R0lSTjdMMlBFVFM3TTVMQTRBIn19.bFElz4g-ZXoz5o64jBBxU2VyZg6SgTCJ2hIS9xgK4udp4uLMtl1NMTd9CG29HGJOlVoccVoBJWy8bwmVqv2_B91yYQfuJcMJrACrY5uhzeOQrlHYE8V9aX_v6EpBMe-PWyFVCugWoJpEuhiKkneyh0ssTp85fCl83Z_EEHl5hesCQZWGXyDz3EWD0Sp6o6Phs_z-j3HvtOV-YHqkAar-Nx0j2mUmCp4oGl7HoJV0tiR9o_3gneDRj7sIAPs74Sfqc6bTmHkaRuYExeN7ZnSoQ5hzGMWao9ykSXwCJrZ-2jc4HFXc_qcYh8R1hQpcxKzkS0kvAnUiEJoHpJDlccBB9w",
            "apiEndpoint": "https://api.eu.amazonalexa.com",
            "application": {
                "applicationId": "amzn1.ask.skill.400c6fef-a18f-44e8-aacb-5249b78214e0"
            },
            "user": {
                "userId": "amzn1.ask.account.AHNN62X4E7MJ4QDSNKHKUURSLPGYCABPJ65VZPXPMTNERCQUKPFTW6SKYVJSSO6DT3T4VZRP34SGSZTMX2WJNPR5NIJ6FVTWP2UE2ZEXE53WZSFJFHJSHM4DXIQJ6E3U4AYQCTS4JY436K3MJEECIBDDWMSAX5BCV2GR2YTHPWEG754Q3TNRLHUUY52C6GIRN7L2PETS7M5LA4A",
                "accessToken": null,
                "permissions": null
            },
            "device": {
                "deviceId": "amzn1.ask.device.AF7KV3I7MFWMZ2H35HWUFQOVZNVGSQYVQQFTQZBOMYCSOQ3N6HLFN23PFQLRTDCCND3DBIL3VTZ5FW7CVAUVW7PK4EBBTZ3LFX6H5YAQ56G4V7ADMPJ25WKVAGXQCA3FSYH5QIIGQWQ4Z2YDDISE5OGIHFNA",
                "supportedInterfaces": {}
            }
        },
        "AudioPlayer": null
    },
    "request": {
        "type": "LaunchRequest",
        "requestId": "amzn1.echo-api.request.3608629f-b3aa-4ee0-bddb-e781a503be89",
        "locale": "de-DE",
        "timestamp": "2018-07-15T06:44:07Z"
    }
}
 * Response:
{
    "version": "1.0",
    "response": {
        "outputSpeech": {
            "type": "PlainText",
            "text": "Heute fahren die nächsten Busse um 8:49, 9:19 und 9:49 von Vier Linden ab, Insgesamt fahren heute noch 30 Busse."
        },
        "shouldEndSession": true
    }
}
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.Lambda.Core;
using Alexa.NET.Response;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Busplan
{
    public class TimeTable
    {
        public string Start { get; set; }
        public string Destination { get; set; }
        public int[] WeekdayList { get; set; }
        public int[] SaturdayList { get; set; }
        public int[] SundayList { get; set; }
    };

    public class Function
    {
        private const string Moltkestrasse = "Moltkestrasse";
        private const string Uni = "Uni";
        private const string Bahnhof = "Bahnhof";

        public static TimeTable Moltkestrasse_Uni = new TimeTable()
            {
                Start = Moltkestrasse,
                Destination = Uni,
                WeekdayList = new[] {
                    502, 532,
                    602, 622, 642,
                    702, 711, 721, 729, 739, 749, 759,
                    809, 829, 849,
                    909, 929, 949,
                    1009, 1029, 1049,
                    1109, 1129, 1149,
                    1209, 1229, 1249, 1259,
                    1309, 1319, 1329, 1339, 1349, 1359,
                    1409, 1419, 1429, 1439, 1449, 1459,
                    1509, 1519, 1529, 1539, 1549, 1559,
                    1609, 1619, 1629, 1639, 1649, 1659,
                    1709, 1719, 1729, 1739, 1749, 1759,
                    1809, 1819, 1829, 1839, 1849, 1859,
                    1909, 1919, 1939, 1959,
                    2019
                },
                SaturdayList = new[] {
                    532,
                    602, 632,
                    702, 732,
                    802, 829, 849,
                    902, 929, 949,
                    1009, 1029, 1049,
                    1109, 1129, 1149,
                    1209, 1229, 1249, 1259,
                    1309, 1319, 1329, 1339, 1349, 1359,
                    1409, 1419, 1429, 1439, 1449, 1459,
                    1509, 1519, 1529, 1539, 1549, 1559,
                    1609, 1619, 1629, 1649,
                    1709, 1729, 1749,
                    1809
                },
                SundayList = new[] {
                    1824,
                    1924,
                    2024,
                    2124,
                    2224
                }
            };


        public static TimeTable Moltkestrasse_Bahnhof = new TimeTable()
            {
                Start = Moltkestrasse,
                Destination = Bahnhof,
                WeekdayList = new[] {
                    453,
                    523, 553,
                    613, 633, 653,
                    701, 711, 721, 731, 741, 751,
                    801, 811, 831, 851,
                    911, 931, 951,
                    1011, 1031, 1051,
                    1111, 1131, 1151,
                    1211, 1231, 1241, 1251,
                    1301, 1311, 1321, 1331, 1341, 1351,
                    1401, 1411, 1421, 1431, 1441, 1451,
                    1501, 1511, 1521, 1531, 1541, 1551,
                    1601, 1611, 1621, 1631, 1641, 1651,
                    1701, 1711, 1721, 1731, 1741, 1751,
                    1801, 1811, 1821, 1831, 1841, 1851,
                    1901, 1921, 1941, 
                    2001
                    },
                SaturdayList = new[] {
                        523, 553,
                        623, 653,
                        723, 753,
                        811, 831, 849,
                        911, 931, 949,
                        1011, 1031, 1051,
                        1111, 1131, 1151,
                        1211, 1231, 1241, 1251,
                        1301, 1311, 1321, 1331, 1341, 1351,
                        1401, 1411, 1421, 1431, 1441, 1451,
                        1501, 1511, 1521, 1531, 1541, 1551,
                        1601, 1611, 1631, 1651,
                        1711, 1731, 1751,
                        1811
                    },
                SundayList = new[] {
                        0000
                    }
            };

        Dictionary<string, TimeTable> TimeTables = new Dictionary<string, TimeTable>
        {
            { $"{Moltkestrasse}-{Uni}", Moltkestrasse_Uni },
            { $"{Moltkestrasse}-{Bahnhof}", Moltkestrasse_Bahnhof },
         };

    
        /// <summary>
        /// Returns bus times
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            SkillResponse response = new SkillResponse
            {
                Response = new ResponseBody()
            };
            response.Response.ShouldEndSession = false;
            IOutputSpeech innerResponse = null;
            var log = context.Logger;
            log.LogLine($"Skill Request Object:");
            log.LogLine(JsonConvert.SerializeObject(input));

            //foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            //    log.LogLine(z.Id);

            if (input.GetRequestType() == typeof(LaunchRequest))
            {
                log.LogLine($"Default LaunchRequest made: 'Alexa, open Busplan");
                innerResponse = new PlainTextOutputSpeech();
                (innerResponse as PlainTextOutputSpeech).Text =
                    GetNextBusAnnouncement(Moltkestrasse, Uni) +
                    GetNextBusAnnouncement(Moltkestrasse, Bahnhof);
                response.Response.ShouldEndSession = true;
            }
            else if (input.GetRequestType() == typeof(IntentRequest))
            {
                var intentRequest = (IntentRequest)input.Request;

                switch (intentRequest.Intent.Name)
                {
                    case "AMAZON.CancelIntent":
                    case "AMAZON.StopIntent":
                        log.LogLine($"{intentRequest.Intent.Name}: send StopMessage");
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "Stopped";
                        response.Response.ShouldEndSession = true;
                        break;
                    case "AMAZON.HelpIntent":
                        log.LogLine($"AMAZON.HelpIntent: send HelpMessage");
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "Help";
                        break;
                    default:
                        log.LogLine($"default intent: " + intentRequest.Intent.Name);
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "default";
                        break;
                }
            }

            response.Response.OutputSpeech = innerResponse;
            response.Version = "1.0";
            log.LogLine($"Skill Response Object...");
            log.LogLine(JsonConvert.SerializeObject(response));
            return response;
        }

        private string ToSpeech(int departureTime)
        {
            return $"{(departureTime / 100)}:{departureTime % 100,2:D2}";
        }

        public IEnumerable<int> GetNextBusses(int[] list, int now)
        {
            return list.Where(e => e >= now);
        }

        private IEnumerable<int> GetNextBusses(string start, string destination)
        {
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Berlin");
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone);
            var time = 100 * now.Hour + now.Minute;
            var weekDay = (int)now.DayOfWeek; // 0 = Sunday
            var route = $"{start}-{destination}";
            var timeTable = TimeTables[route];
            return (weekDay == 0) ?
                GetNextBusses(timeTable.SundayList, time) :
                (weekDay == 6) ?
                    GetNextBusses(timeTable.SaturdayList, time) :
                    GetNextBusses(timeTable.WeekdayList, time);
        }

        string GetNextBusAnnouncement(string start, string destination)
        {
            var route = $"{start}-{destination}";

            var busses = GetNextBusses(start, destination).ToList();

            if (busses.Count == 0)
                return route + $": Heute fahren leider keine Busse mehr. ";
            if (busses.Count == 1)
                return route + $": Heute fährt der letzte Bus um {ToSpeech(busses[0])}. ";
            if (busses.Count == 2)
                return route + $": Heute fahren Busse um {ToSpeech(busses[0])} und {ToSpeech(busses[1])}. ";

            return route + $": Heute fahren die nächsten Busse um {ToSpeech(busses[0])}, " +
                $"{ToSpeech(busses[1])} und {ToSpeech(busses[2])}. ";
                //$"Insgesamt fahren heute noch {busses.Count} Busse.";
        }
    }
}