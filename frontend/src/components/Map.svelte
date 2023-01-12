<script lang="ts">
  import MapboxGeocoder from "@mapbox/mapbox-gl-geocoder";
  import type { Result } from "@mapbox/mapbox-gl-geocoder";
  import mapboxgl from "mapbox-gl";
  import {onMount} from "svelte";
  
  let lon: number;
  let lat: number;

  onMount(() => { 
    mapboxgl.accessToken = "pk.eyJ1IjoidHJ6Y2luMSIsImEiOiJjbGN0M2pneTkwOWxhM3BxdDZsOWpkdGZ6In0.5Ot2WYhpkxNyNZA8b28xgw";

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
    })
  });

</script>

<div id="map"></div>
{#if lat && lon}
  <h1>{lon} {lat}</h1>
{/if}

<style>
  #map {
    display: block;
    height: calc(100vh - 20rem);
    width: 100%;
    z-index: -1;
  }

  h1 {
    position: absolute;
    z-index: 0;
  }
</style>
