<script lang="ts">
  import type Category from "../types/category";

  export let data: Category[];
  export let displayData: Category[];
  export let groupData: Category[];

  let filter: string = '';
  $: {
    if (filter.trim() != '') {
      displayData = data.filter((category) => 
        category.name.search(new RegExp(filter, 'i')) != -1
      );
    } else {
      displayData = [...groupData];
    }
  }
</script>

<h2>Szukaj kategorii</h2>
<div>
  <img src="/lupka.svg" alt="szukaj">
  <input type="text" placeholder="Wpisz nazwę kategorii" bind:value={filter}/>
</div>

<style>
  h2 {
    margin: 3rem 1.5rem 0 1.5rem;
  }

  div {
    margin: 2rem 1.5rem 0 1.5rem;
    display: flex;
    position: relative;
  }

  input {
    display: block;
    width: 100%;
    max-width: 40rem;
    padding: .5rem 1rem .5rem 2rem;
  }

  img {
    position: absolute;
    top: 50%;
    left: 1rem;
    transform: translate(-50%, -.5rem);
    width: 1rem;
    height: auto;
    filter: brightness(0.5);
  }
</style>
