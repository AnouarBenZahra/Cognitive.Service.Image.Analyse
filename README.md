# Cognitive.Service.Image.Analyse

First, You need to log into the Azure Portal with our Azure credentials. Then we need to create an Azure Computer Vision Subscription Key in the Azure portal.
     Then create a resource to get the Key
     Second, Set the endPoint to "https://westus.api.cognitive.microsoft.com/vision/v1.0/analyze" 
     Finaly to Image information captured using Computer Vision API you should write like this : 
  ImageInfo imageInfo = new ImageInfo();
     var imageInformations= imageInfo.MakeAnalysisRequest(subscriptionKey, imagePath, endPoint);     
     
     Requirements :
     These are the major requirements mentioned in the Microsoft docs.
     1-Supported input methods: Raw image binary in the form of an application/octet stream or image URL.
     2-Supported image formats: JPEG, PNG, GIF, BMP.
     3-Image file size: Less than 4 MB.
     4-Image dimension: Greater than 50 x 50 pixels.
     
