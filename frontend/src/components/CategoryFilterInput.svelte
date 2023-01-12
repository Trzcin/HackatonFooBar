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
<input type="text" placeholder="Wpisz nazwę kategorii" bind:value={filter}/>

<style>
h2 {
  margin: 3rem 1.5rem 0 1.5rem;
}

input {
  display: block;
  margin: 2rem 1.5rem 0 1.5rem;
  width: 100%;
  max-width: 40rem;
  padding: .5rem 1rem .5rem 2rem;
}
</style>
