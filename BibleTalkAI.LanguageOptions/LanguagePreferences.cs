using Twilio.TwiML.Voice;

namespace BibleTalkAI.LanguageOptions;

public static class LanguagePreferences
{
    public static readonly IReadOnlyDictionary<int, LanguagePreference> Languages;

    static LanguagePreferences()
    {
        int primeNumberCapacity = 47;

        // Lithuanian,Basque,Galician static readonly missing from Twilio.TwiML.Voice.Say.LanguageEnum
        Say.LanguageEnum ltlt = SayLanguageEnum("lt-LT"); // Lithuanian
        Say.LanguageEnum eues = SayLanguageEnum("eu-ES"); // Basque
        Say.LanguageEnum gles = SayLanguageEnum("gl-ES"); // Galician

        Languages = new Dictionary<int, LanguagePreference>(primeNumberCapacity)
        {
            [1] = new LanguagePreference
            {
                LanguagePreferenceOption = 1,
                GatherLanguage = Gather.LanguageEnum.EnUs,
                SayVoice = Say.VoiceEnum.PollyMatthewNeural,
                SayLanguage = Say.LanguageEnum.EnUs,
                LanguageNameInEnglish = "English"
            },
            [2] = new LanguagePreference
            {
                LanguagePreferenceOption = 2,
                GatherLanguage = Gather.LanguageEnum.CmnHansCn,
                SayVoice = Say.VoiceEnum.GoogleCmnCnWavenetB,
                SayLanguage = Say.LanguageEnum.CmnCn,
                LanguageNameInEnglish = "Chinese Mandarin"
            },
            [3] = new LanguagePreference
            {
                LanguagePreferenceOption = 3,
                GatherLanguage = Gather.LanguageEnum.HiIn,
                SayVoice = Say.VoiceEnum.GoogleHiInWavenetB,
                SayLanguage = Say.LanguageEnum.HiIn,
                LanguageNameInEnglish = "Hindi"
            },
            [4] = new LanguagePreference
            {
                LanguagePreferenceOption = 4,
                GatherLanguage = Gather.LanguageEnum.EsUs,
                SayVoice = Say.VoiceEnum.PollyPedroNeural,
                SayLanguage = Say.LanguageEnum.EsUs,
                LanguageNameInEnglish = "Spanish"
            },
            [5] = new LanguagePreference
            {
                LanguagePreferenceOption = 5,
                GatherLanguage = Gather.LanguageEnum.ArMa,
                SayVoice = Say.VoiceEnum.GoogleArXaWavenetB,
                SayLanguage = Say.LanguageEnum.ArXa,
                LanguageNameInEnglish = "Arabic"
            },
            [6] = new LanguagePreference
            {
                LanguagePreferenceOption = 6,
                GatherLanguage = Gather.LanguageEnum.MsMy,
                SayVoice = Say.VoiceEnum.GoogleMsMyWavenetB,
                SayLanguage = Say.LanguageEnum.MsMy,
                LanguageNameInEnglish = "Malay"
            },
            [7] = new LanguagePreference
            {
                LanguagePreferenceOption = 7,
                GatherLanguage = Gather.LanguageEnum.FrFr,
                SayVoice = Say.VoiceEnum.PollyRemiNeural,
                SayLanguage = Say.LanguageEnum.FrFr,
                LanguageNameInEnglish = "French"
            },
            [8] = new LanguagePreference
            {
                LanguagePreferenceOption = 8,
                GatherLanguage = Gather.LanguageEnum.PtBr,
                SayVoice = Say.VoiceEnum.PollyThiagoNeural,
                SayLanguage = Say.LanguageEnum.PtBr,
                LanguageNameInEnglish = "Portuguese"
            },
            [9] = new LanguagePreference
            {
                LanguagePreferenceOption = 9,
                GatherLanguage = Gather.LanguageEnum.RuRu,
                SayVoice = Say.VoiceEnum.GoogleRuRuWavenetB,
                SayLanguage = Say.LanguageEnum.RuRu,
                LanguageNameInEnglish = "Russian"
            },
            [10] = new LanguagePreference
            {
                LanguagePreferenceOption = 10,
                GatherLanguage = Gather.LanguageEnum.IdId,
                SayVoice = Say.VoiceEnum.GoogleIdIdWavenetB,
                SayLanguage = Say.LanguageEnum.IdId,
                LanguageNameInEnglish = "Indonesian"
            },
            [11] = new LanguagePreference
            {
                LanguagePreferenceOption = 11,
                GatherLanguage = Gather.LanguageEnum.DeDe,
                SayVoice = Say.VoiceEnum.PollyDanielNeural,
                SayLanguage = Say.LanguageEnum.DeDe,
                LanguageNameInEnglish = "German"
            },
            [12] = new LanguagePreference
            {
                LanguagePreferenceOption = 12,
                GatherLanguage = Gather.LanguageEnum.JaJp,
                SayVoice = Say.VoiceEnum.PollyTakumiNeural,
                SayLanguage = Say.LanguageEnum.JaJp,
                LanguageNameInEnglish = "Japanese"
            },
            //[13] = new LanguagePreference
            //{
            //    LanguagePreferenceOption = 13,
            //    GatherLanguage = Gather.LanguageEnum.PaIn, // gather language does not support Punjabi
            //    SayVoice = Say.VoiceEnum.GooglePaInWavenetB,
            //    SayLanguage = Say.LanguageEnum.PaIn
            //},
            [14] = new LanguagePreference
            {
                LanguagePreferenceOption = 14,
                GatherLanguage = Gather.LanguageEnum.MrIn,
                SayVoice = Say.VoiceEnum.GoogleMrInWavenetB,
                SayLanguage = Say.LanguageEnum.MrIn,
                LanguageNameInEnglish = "Marathi"
            },
            [15] = new LanguagePreference
            {
                LanguagePreferenceOption = 15,
                GatherLanguage = Gather.LanguageEnum.TeIn,
                SayVoice = Say.VoiceEnum.GoogleTeInStandardB,
                SayLanguage = Say.LanguageEnum.TeIn,
                LanguageNameInEnglish = "Telugu"
            },
            [16] = new LanguagePreference
            {
                LanguagePreferenceOption = 16,
                GatherLanguage = Gather.LanguageEnum.KoKr,
                SayVoice = Say.VoiceEnum.GoogleKoKrWavenetC,
                SayLanguage = Say.LanguageEnum.KoKr,
                LanguageNameInEnglish = "Korean"
            },
            [17] = new LanguagePreference
            {
                LanguagePreferenceOption = 17,
                GatherLanguage = Gather.LanguageEnum.ViVn,
                SayVoice = Say.VoiceEnum.GoogleViVnWavenetB,
                SayLanguage = Say.LanguageEnum.ViVn,
                LanguageNameInEnglish = "Vietnamese"
            },
            [18] = new LanguagePreference
            {
                LanguagePreferenceOption = 18,
                GatherLanguage = Gather.LanguageEnum.TaIn,
                SayVoice = Say.VoiceEnum.GoogleTaInWavenetD,
                SayLanguage = Say.LanguageEnum.TaIn,
                LanguageNameInEnglish = "Tamil"
            },
            [19] = new LanguagePreference
            {
                LanguagePreferenceOption = 19,
                GatherLanguage = Gather.LanguageEnum.TrTr,
                SayVoice = Say.VoiceEnum.GoogleTrTrWavenetB,
                SayLanguage = Say.LanguageEnum.TrTr,
                LanguageNameInEnglish = "Turkish"
            },
            [20] = new LanguagePreference
            {
                LanguagePreferenceOption = 20,
                GatherLanguage = Gather.LanguageEnum.YueHantHk,
                SayVoice = Say.VoiceEnum.GoogleYueHkStandardB,
                SayLanguage = Say.LanguageEnum.YueHk,
                LanguageNameInEnglish = "Chinese Cantonese"
            },
            [21] = new LanguagePreference
            {
                LanguagePreferenceOption = 21,
                GatherLanguage = Gather.LanguageEnum.ItIt,
                SayVoice = Say.VoiceEnum.PollyAdrianoNeural,
                SayLanguage = Say.LanguageEnum.ItIt,
                LanguageNameInEnglish = "Italian"
            },
            [22] = new LanguagePreference
            {
                LanguagePreferenceOption = 22,
                GatherLanguage = Gather.LanguageEnum.PlPl,
                SayVoice = Say.VoiceEnum.GooglePlPlWavenetB,
                SayLanguage = Say.LanguageEnum.PlPl,
                LanguageNameInEnglish = "Polish"
            },
            [23] = new LanguagePreference
            {
                LanguagePreferenceOption = 23,
                GatherLanguage = Gather.LanguageEnum.MlIn,
                SayVoice = Say.VoiceEnum.GoogleMlInWavenetD,
                SayLanguage = Say.LanguageEnum.MlIn,
                LanguageNameInEnglish = "Malayalam"
            },
            [24] = new LanguagePreference
            {
                LanguagePreferenceOption = 24,
                GatherLanguage = Gather.LanguageEnum.FilPh,
                SayVoice = Say.VoiceEnum.GoogleFilPhWavenetB,
                SayLanguage = Say.LanguageEnum.FilPh,
                LanguageNameInEnglish = "Filipino"
            },
            [25] = new LanguagePreference
            {
                LanguagePreferenceOption = 25,
                GatherLanguage = Gather.LanguageEnum.NlNl,
                SayVoice = Say.VoiceEnum.GoogleNlNlWavenetB,
                SayLanguage = Say.LanguageEnum.NlNl,
                LanguageNameInEnglish = "Dutch"
            },
            [26] = new LanguagePreference
            {
                LanguagePreferenceOption = 26,
                GatherLanguage = Gather.LanguageEnum.SvSe,
                SayVoice = Say.VoiceEnum.GoogleSvSeWavenetC,
                SayLanguage = Say.LanguageEnum.SvSe,
                LanguageNameInEnglish = "Swedish"
            },
            [27] = new LanguagePreference
            {
                LanguagePreferenceOption = 27,
                GatherLanguage = Gather.LanguageEnum.HeIl,
                SayVoice = Say.VoiceEnum.GoogleHeIlWavenetB,
                SayLanguage = Say.LanguageEnum.HeIl,
                LanguageNameInEnglish = "Hebrew"
            },
            [28] = new LanguagePreference
            {
                LanguagePreferenceOption = 28,
                GatherLanguage = Gather.LanguageEnum.DaDk,
                SayVoice = Say.VoiceEnum.GoogleDaDkWavenetC,
                SayLanguage = Say.LanguageEnum.DaDk,
                LanguageNameInEnglish = "Danish"
            },
            [29] = new LanguagePreference
            {
                LanguagePreferenceOption = 29,
                GatherLanguage = Gather.LanguageEnum.NbNo,
                SayVoice = Say.VoiceEnum.GoogleNbNoWavenetB,
                SayLanguage = Say.LanguageEnum.NbNo,
                LanguageNameInEnglish = "Norwegian"
            },
            [30] = new LanguagePreference
            {
                LanguagePreferenceOption = 30,
                GatherLanguage = Gather.LanguageEnum.LtLt,
                SayVoice = Say.VoiceEnum.GoogleLtLtStandardA,
                SayLanguage = ltlt,
                LanguageNameInEnglish = "Lithuanian"
            },
            [31] = new LanguagePreference
            {
                LanguagePreferenceOption = 31,
                GatherLanguage = Gather.LanguageEnum.LvLv,
                SayVoice = Say.VoiceEnum.GoogleLvLvStandardA,
                SayLanguage = Say.LanguageEnum.LvLv,
                LanguageNameInEnglish = "Latvian"
            },
            [32] = new LanguagePreference
            {
                LanguagePreferenceOption = 32,
                GatherLanguage = Gather.LanguageEnum.AfZa,
                SayVoice = Say.VoiceEnum.GoogleAfZaStandardA,
                SayLanguage = Say.LanguageEnum.AfZa,
                LanguageNameInEnglish = "Afrikaans"
            },
            [33] = new LanguagePreference
            {
                LanguagePreferenceOption = 33,
                GatherLanguage = Gather.LanguageEnum.EuEs,
                SayVoice = Say.VoiceEnum.GoogleEuEsStandardA,
                SayLanguage = eues,
                LanguageNameInEnglish = "Basque"
            },
            [34] = new LanguagePreference
            {
                LanguagePreferenceOption = 34,
                GatherLanguage = Gather.LanguageEnum.BgBg,
                SayVoice = Say.VoiceEnum.GoogleBgBgStandardA,
                SayLanguage = Say.LanguageEnum.BgBg,
                LanguageNameInEnglish = "Bulgarian"
            },
            [35] = new LanguagePreference
            {
                LanguagePreferenceOption = 35,
                GatherLanguage = Gather.LanguageEnum.CaEs,
                SayVoice = Say.VoiceEnum.PollyArletNeural,
                SayLanguage = Say.LanguageEnum.CaEs,
                LanguageNameInEnglish = "Catalan"
            },
            [36] = new LanguagePreference
            {
                LanguagePreferenceOption = 36,
                GatherLanguage = Gather.LanguageEnum.CsCz,
                SayVoice = Say.VoiceEnum.GoogleCsCzWavenetA,
                SayLanguage = Say.LanguageEnum.CsCz,
                LanguageNameInEnglish = "Czech"
            },
            [37] = new LanguagePreference
            {
                LanguagePreferenceOption = 37,
                GatherLanguage = Gather.LanguageEnum.FiFi,
                SayVoice = Say.VoiceEnum.PollySuviNeural,
                SayLanguage = Say.LanguageEnum.FiFi,
                LanguageNameInEnglish = "Finnish"
            },
            [38] = new LanguagePreference
            {
                LanguagePreferenceOption = 38,
                GatherLanguage = Gather.LanguageEnum.GlEs,
                SayVoice = Say.VoiceEnum.GoogleGlEsStandardA,
                SayLanguage = gles,
                LanguageNameInEnglish = "Galician"
            },
            [39] = new LanguagePreference
            {
                LanguagePreferenceOption = 39,
                GatherLanguage = Gather.LanguageEnum.ElGr,
                SayVoice = Say.VoiceEnum.GoogleElGrWavenetA,
                SayLanguage = Say.LanguageEnum.ElGr,
                LanguageNameInEnglish = "Greek"
            },
            [40] = new LanguagePreference
            {
                LanguagePreferenceOption = 40,
                GatherLanguage = Gather.LanguageEnum.HuHu,
                SayVoice = Say.VoiceEnum.GoogleHuHuWavenetA,
                SayLanguage = Say.LanguageEnum.HuHu,
                LanguageNameInEnglish = "Hungarian"
            },
            [41] = new LanguagePreference
            {
                LanguagePreferenceOption = 41,
                GatherLanguage = Gather.LanguageEnum.IsIs,
                SayVoice = Say.VoiceEnum.PollyKarl,
                SayLanguage = Say.LanguageEnum.IsIs,
                LanguageNameInEnglish = "Icelandic"
            },
            [42] = new LanguagePreference
            {
                LanguagePreferenceOption = 42,
                GatherLanguage = Gather.LanguageEnum.RoRo,
                SayVoice = Say.VoiceEnum.GoogleRoRoWavenetA,
                SayLanguage = Say.LanguageEnum.RoRo,
                LanguageNameInEnglish = "Romanian"
            },
            [43] = new LanguagePreference
            {
                LanguagePreferenceOption = 43,
                GatherLanguage = Gather.LanguageEnum.SrRs,
                SayVoice = Say.VoiceEnum.GoogleSrRsStandardA,
                SayLanguage = Say.LanguageEnum.SrRs,
                LanguageNameInEnglish = "Serbian"
            },
            [44] = new LanguagePreference
            {
                LanguagePreferenceOption = 44,
                GatherLanguage = Gather.LanguageEnum.SkSk,
                SayVoice = Say.VoiceEnum.GoogleSkSkWavenetA,
                SayLanguage = Say.LanguageEnum.SkSk,
                LanguageNameInEnglish = "Slovak"
            },
            [45] = new LanguagePreference
            {
                LanguagePreferenceOption = 45,
                GatherLanguage = Gather.LanguageEnum.ThTh,
                SayVoice = Say.VoiceEnum.GoogleThThStandardA,
                SayLanguage = Say.LanguageEnum.ThTh,
                LanguageNameInEnglish = "Thai"
            },
            [46] = new LanguagePreference
            {
                LanguagePreferenceOption = 46,
                GatherLanguage = Gather.LanguageEnum.UkUa,
                SayVoice = Say.VoiceEnum.GoogleUkUaWavenetA,
                SayLanguage = Say.LanguageEnum.UkUa,
                LanguageNameInEnglish = "Ukrainian"
            },
        };

    }

    private static Say.LanguageEnum SayLanguageEnum(string lang)
    {
        Say.LanguageEnum sayLanguage = new();
        sayLanguage.FromString(lang);
        return sayLanguage;
    }
}
