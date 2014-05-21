/**
 *
 * @authors Your Name (you@example.org)
 * @date    2014-05-15 20:32:45
 * @version $Id$
 */



$(function() {

	var options = {
		chart: {
			renderTo: "container",
			type: "bar"
		},
		series: [{
			name: "jane",
			data: [1, 10, 5, 1]
		}]
	};

	options.series.push({
		name: "John",
		data: [1, 10, 5, 40]
	});
	
	var chart = new Highcharts.Chart(options);

	
	// $('#container').highcharts({
	// 	chart: {
	// 		type: 'column'
	// 	},
	// 	title: {
	// 		text: 'Fruit Consumption'
	// 	},
	// 	xAxis: {
	// 		categories: ['Apples', 'Bananas', 'Oranges']
	// 	},
	// 	yAxis: {
	// 		title: {
	// 			text: 'Fruit eaten'
	// 		}
	// 	},
	// 	series: [{
	// 		name: 'Jane',
	// 		data: [1, 0, 4]
	// 	}, {
	// 		name: 'John',
	// 		data: [5, 7, 3]
	// 	}, {
	// 		name: "succes",
	// 		data: [1, 2, 10]
	// 	}]
	// });
});