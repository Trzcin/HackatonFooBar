<script lang="ts">
  import MapboxGeocoder from "@mapbox/mapbox-gl-geocoder";
  import type { Result } from "@mapbox/mapbox-gl-geocoder";
  import mapboxgl from "mapbox-gl";
  import {onMount} from "svelte";
  
  let lon: number;
  let lat: number;

  onMount(() => { 
    mapboxgl.accessToken = import.meta.env.VITE_MAPBOX;

    const map = new mapboxgl.Map({
      container: 'map',
      style: 'mapbox://styles/mapbox/streets-v12',
      center: [18.6667, 54.35],
      zoom: 13
    });

    const geocoder = new MapboxGeocoder({
      accessToken: mapboxgl.accessToken,
      mapboxgl: mapboxgl,
    });

    map.addControl(geocoder);

    geocoder.on('result', (e) => {
      const result: Result = e.result;
      lon = result.center[0];
      lat = result.center[1];
      mapExpanded = false;
    });
  });
  export let mapExpanded: boolean;
</script>

<div id="map" class:not-expanded={!mapExpanded}></div>

<style>
  #map {
    display: block;
    height: calc(100vh - 4rem);
    width: 100%;
  }

  .not-expanded {
    height: calc(100vh - 20rem) !important;
  }
</style>
