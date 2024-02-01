import { create } from "zustand";

interface IMember {
  firstName: string;
  lastName: string;
  memberId: string;
  username: string;
  email: string;
  address: string;
  phoneNumber: string;
}

interface Action {
  updateId: (id: string) => void;
  updateUsername: (username: string) => void;
  updateEmail: (Email: string) => void;
  updateFirstName: (firstName: string) => void;
  updateLastName: (lastName: string) => void;
  updateAddress: (address: string) => void;
  updatePhone: (phone: string) => void;
}

export const useMemberStore = create<IMember & Action>((set) => ({
  firstName: "",
  lastName: "",
  memberId: "",
  username: "",
  email: "",
  address: "",
  phoneNumber: "",
  updateId: (id) => {
    set((_state) => ({ memberId: id }));
  },
  updateUsername: (newUsername) => {
    set((_state) => ({ username: newUsername }));
  },
  updateEmail: (Email) => {
    set((_state) => ({ email: Email }));
  },
  updateFirstName: (firstName) => {
    set((_state) => ({ firstName }));
  },
  updateLastName: (lastName) => {
    set((_state) => ({ lastName }));
  },
  updateAddress: (address) => {
    set((_state) => ({ address }));
  },
  updatePhone: (phone) => {
    set((_state) => ({ phoneNumber: phone }));
  },
}));
