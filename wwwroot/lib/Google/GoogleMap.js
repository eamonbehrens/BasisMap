
function initMap() {
    var mapDiv = document.getElementById('map');
    var map = new google.maps.Map(mapDiv, {
        // center: { lat: 95.7129, lng: 37.0902 },
        center: { lat: 37.09024, lng: -95.71291 },//US
        //center: { lat: -34.397, lng: 150.644 },
        zoom: 5,
        
    });
}
