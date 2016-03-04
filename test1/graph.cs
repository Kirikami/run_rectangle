using System;

namespace test1
{
	public class StoreViewModel : IObservableChartPoint
	{
		private double _income;

		public double Income
		{
			get { return _income; }
			set
			{
				_income = value;
				if (ValueChanged != null) ValueChanged.Invoke();
			}
		}

		public event Action ValueChanged;
	}

	//create a config for StoreViewModel
	var config = new SeriesConfiguration<StoreViewModel>()
		.Y(y => y.Income); //use Income property as Y
	//do not configure X
	//this will pull a zero based index as X

	//create a SeriesCollection with this config
	var storesCollection = new SeriesCollection(config);

	//add some Series with ChartValues<StoreViewModel>
	storesCollection.Add(new BarSeries
		{
			Title = "Apple Store",
			Values = new ChartValues<StoreViewModel>
			{
				new StoreViewModel {Income = 15}
			}
		});
	storesCollection.Add(new BarSeries
		{
			Title = "Google Play",
			Values = new ChartValues<StoreViewModel>
			{
				new StoreViewModel {Income = 5}
			}
		});

	//finally use set storesCollection instance to Chart.Series, 
	//use wpf binding if necessary
	myChart.Series = storesCollection;

}

