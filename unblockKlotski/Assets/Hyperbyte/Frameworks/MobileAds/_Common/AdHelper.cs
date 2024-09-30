﻿// ©2019 - 2020 HYPERBYTE STUDIOS LLP
// All rights reserved
// Redistribution of this software is strictly not allowed.
// Copy of this software can be obtained from unity asset store only.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnityEngine;

namespace Hyperbyte.Ads
{
    /// <summary>
    /// Abstract class for invoking ads.
    /// </summary>
    public abstract class AdHelper : MonoBehaviour
    {
        // Initializes the ad network.
        public abstract void InitializeAdNetwork();

        // Shows banner ad.
        public abstract void ShowBanner();
        
        // Hides banner ad.
        public abstract void HideBanner();
        
        //  Checks if interstitil ad is available.
        public abstract bool IsInterstitialAvailable();
        
        // Shows interstitial ad.
        public abstract void ShowInterstitial(Action<bool> closeCallBack);
        
        // Checks if rewarded ad is available.
        public abstract bool IsRewardedAvailable();
        
        // Shows rewarded ad.
        public abstract void ShowRewarded();
    }
}