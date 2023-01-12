<script lang="ts">
  import mapboxgl from "mapbox-gl";

  mapboxgl.accessToken = "pk.eyJ1IjoidHJ6Y2luMSIsImEiOiJjbGN0M2pneTkwOWxhM3BxdDZsOWpkdGZ6In0.5Ot2WYhpkxNyNZA8b28xgw";

  const map = new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/streets-v12',
    center: [54.35, 18.6667],
    zoom: 13
  });

  
</script>

<div id="map"></div>

<style>
  #map {
    position: absolute;
    top: 4rem;
    bottom: 0;
    widows: 100%;
  }
</style>
