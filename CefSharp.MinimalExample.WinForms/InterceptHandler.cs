// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp.Handler;

namespace CefSharp.MinimalExample.WinForms
{
    internal class InterceptHandler : RequestHandler
    {
        protected override bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
        {            
            if (request.Url.StartsWith("http"))
            {
                // Naive if web link, open external

                // Open Google in Default browser 
                System.Diagnostics.Process.Start(request.Url);
                return true;
            }            
            else
            {
                // Still need to load files is why this is needed.
                return false;
            }
        }
    }
}