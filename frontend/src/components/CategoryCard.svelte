<script lang="ts">
  import type Category from "../types/category";

  export let category: Category = undefined;
</script>

<div class="card">
  <h1>{category.name}</h1>
</div>

<style>
  .card {
    width: 100%;
  }
</style>
