let _map = null;

function mapLeaflet(x, y)
{
    if(!maps.classList.contains("leaflet-container"))
    {
        _map = L.map(maps);
    }

    var map = _map.setView([x, y], 15);
    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
    }).addTo(map);
    var marker = L.marker([x, y]).addTo(map);
}