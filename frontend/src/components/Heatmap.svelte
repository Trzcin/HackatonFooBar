<script lang="ts">
  import mapboxgl from "mapbox-gl";

  import {onMount} from "svelte";

  onMount(() => {
    mapboxgl.accessToken = 'pk.eyJ1IjoidHJ6Y2luMSIsImEiOiJjbGN0M2pneTkwOWxhM3BxdDZsOWpkdGZ6In0.5Ot2WYhpkxNyNZA8b28xgw';

    const map = new mapboxgl.Map({
      container: 'map',
      style: 'mapbox://styles/mapbox/streets-v12',
      center: [18.6667, 54.35],
      zoom: 13
    });
  });
</script>

<div id="map"></div>

<style>
  #map {
    display: block;
    height: calc(100vh - 4rem);
    width: 100%;
  }
</style>
