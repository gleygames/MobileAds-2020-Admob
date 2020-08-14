namespace GoogleMobileAds.Editor
{
	public class GleyAdmobPatch 
	{
        public static void SetAdmobAppID(string androidAppId, string iosAppID)
        {
#if USE_ADMOB
            GoogleMobileAdsSettings.Instance.IsAdMobEnabled = true;
            GoogleMobileAdsSettings.Instance.AdMobAndroidAppId = androidAppId;
            GoogleMobileAdsSettings.Instance.AdMobIOSAppId = iosAppID;
#endif
        }
    }
}