using CCPPApplicationML.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCPPApplication.Controllers
{
    public class PredictionsController : Controller
    {
        public IActionResult Index(ModelInput input)
        {
            // Create ML Context
            MLContext mLContext = new MLContext();

            // Load the model
            ITransformer mlModel = mLContext.Model.Load(@"..\CCPPApplicationML.Model\MLModel.zip", out var modelInputSchema);

            // Create prediction engine needed to load trained model
            var predictionEngine = mLContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Try model on data to predict fare price
            ModelOutput result = predictionEngine.Predict(input);

            // Predicted Fare in UI
            ViewBag.FarePrice = result.Score;

            return View(input);
        }

    }
}
