using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Banner : MonoBehaviour
{ 
    private BannerView bannerView;
    public string adUnitId = "ca-app-pub-9457289458053843/8618865586";
    public AdPosition adPosition;
    private void Start()
    {
        bannerView = new BannerView(adUnitId, AdSize.Banner, adPosition);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }

}
