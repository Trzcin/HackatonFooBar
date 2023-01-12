interface Category {
  name: string;
  nearest: {
    lon: number;
    lat: number;
  };
  time: string;
}

export default Category;
