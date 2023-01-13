interface Category {
  name: string;
  nearest: { lon: number; lat: number };
  link?: string;
  time: string;
}

export default Category;
