export const itemCounter = (value: boolean[], index: boolean) => {
  return value.filter((x) => x == index).length;
};
