import { create } from "zustand";

interface IMember {
  firstName: string;
  lastName: string;
  memberId: string;
  dateOfBirth: string;
  email: string;
  address: string;
  phoneNumber: string;
}

interface Action {
  updateId: (id: string) => void;
  updateDateOfBirth: (username: string) => void;
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
  dateOfBirth: "",
  email: "",
  address: "",
  phoneNumber: "",
  updateId: (id) => {
    set((_state) => ({ memberId: id }));
  },
  updateDateOfBirth: (dob) => {
    set((_state) => ({ dateOfBirth: dob }));
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
