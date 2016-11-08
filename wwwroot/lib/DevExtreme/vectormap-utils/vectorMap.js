

var markers = [{
    coordinates: [-121.2808, 38.3320],
    attributes: { text: 'Sacramento' }
}, {
    coordinates: [-97.75, 30.25],
    attributes: { text: 'Austin' }
}, {
    coordinates: [-73.7572, 42.6525],
    attributes: { text: 'Albany' }
}, {
    coordinates: [-84.2533, 30.455],
    attributes: { text: 'Tallahassee' }
}, {
    coordinates: [-89.65, 39.783],
    attributes: { text: 'Springfield' }
}, {
    coordinates: [-76.8756, 40.2697],
    attributes: { text: 'Harrisburg' }
}, {
    coordinates: [-82.9833, 39.9833],
    attributes: { text: 'Columbus' }
}, {
    coordinates: [-84.39, 33.755],
    attributes: { text: 'Atlanta' }
}, {
    coordinates: [-84.5467, 42.7336],
    attributes: { text: 'Lansing' }
}, {
    coordinates: [-78.6447, 35.8189],
    attributes: { text: 'Raleigh' }
}];

var mostPopulatedStates = ['California', 'Texas', 'New York', 'Florida', 'Illinois', 'Pennsylvania', 'Ohio', 'Georgia', 'Michigan', 'North Carolina'];

$(function () {
    $('#mapContainer').dxVectorMap({
        layers: [{
            type: 'area',
            dataSource: DevExpress.viz.map.sources.usa,
            customize: function (elements) {
                for (i in elements) {
                    if ($.inArray(elements[i].attribute('name'), mostPopulatedStates) > -1)
                        elements[i].applySettings({ color: 'forestgreen' });
                }
            },
            color: 'yellowgreen',
            selectedColor: 'mediumaquamarine',
            selectedBorderColor: 'darkgreen',
            selectionMode: 'multiple'
        }, {
            type: 'marker',
            dataSource: markers,
            label: {
                dataField: 'text',
                font: { size: 11 }
            },
            selectedColor: 'dodgerblue'
        }],
        bounds: [-133.5, 60, -63.5, 20],
        zoomFactor: 1.25,
        background: {
            color: 'paleturquoise'
        },
        onClick: function (info) {
            var clickedElement = info.target;
            if (clickedElement != null)
                clickedElement.selected(!clickedElement.selected());
        },
        pathModified: true,
        controlBar: {
            borderColor: 'lightseagreen'
        },
        tooltip: {
            enabled: true,
            customizeTooltip: function (element) {
                if (element.layer.type == 'area') {
                    return {
                        text: element.attribute('name')
                    };
                }
            }
        }
    });
});
