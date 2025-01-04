//Load sample data
using ML_text_sentiments_analysis;

var sampleData = new TextsSentimentModel.ModelInput()
{
    Col0 = @"Fisayo is super duper not amazing.",
};

//Load model and predict output
var result = TextsSentimentModel.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Feature: {sampleData.Col0}\nSentiment : {sentiment}");
