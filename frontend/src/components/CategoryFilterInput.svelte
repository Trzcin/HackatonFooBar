<script lang="ts">
  import type Category from "../types/category";

  export let data: Category[];
  export let displayData: Category[];

  let filter: string = '';
  $: {
    if (filter.trim() != '') {
      displayData = data.filter((category) => 
        category.name.search(new RegExp(filter, 'i')) != -1
      );
    } else {
      displayData = [...data];
    }
  }
</script>

<input type="text" placeholder="Szukaj w kategoriach..." bind:value={filter}/>
