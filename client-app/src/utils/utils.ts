export const itemCounter = (value: boolean[], index: boolean) => {
  return value.filter((x) => x == index).length;
};

export const fetchMember = async (memberId: string) => {
  try {
    const response = await fetch(
      `http://localhost:5002/api/v1/profile/${memberId}`
    );
    if (!response.ok) {
      throw new Error(`Failed to fetch member data: ${response.status}`);
    }
    const data = await response.json();
    return data;
  } catch (error: any) {
    console.error("Error fetching member data:", error.message);
    throw error; // Rethrow the error to handle it in the calling code if needed
  }
};
