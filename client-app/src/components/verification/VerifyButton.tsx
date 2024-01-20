import { useState } from "react";
import { Button } from "../ui/button";
import {
  Dialog,
  DialogContent,
  DialogDescription,
  DialogFooter,
  DialogHeader,
  DialogTitle,
  DialogTrigger,
} from "@/components/ui/dialog";
import { Input } from "@/components/ui/input";

import successIcon from "@/assets/Verification/success.png";
import failIcon from "@/assets/Verification/fail.png";

export const VerifyButton = () => {
  const [isVerified, setIsVerified] = useState(false);
  const [isOpen, setIsOpen] = useState(false);
  const handleVerifyButton = () => {
    setIsVerified(true);
    setIsOpen(false);
  };
  return (
    <>
      <Dialog open={isOpen} onOpenChange={setIsOpen}>
        <DialogTrigger asChild>
          <Button className="h-full w-full border shadow-md bg-background rounded-2xl hover:bg-slate-50">
            <div className="flex gap-2 p-4">
              <p className="text-lg text-black">
                {isVerified ? "Verified" : "Verify"}
              </p>

              {
                <img
                  className="h-6"
                  src={isVerified ? successIcon : failIcon}
                />
              }
            </div>
          </Button>
        </DialogTrigger>
        <DialogContent className="sm:max-w-[425px]">
          <DialogHeader>
            <DialogTitle>Verify Member</DialogTitle>
            <DialogDescription>
              Make changes to your profile here. Click save when you're done.
            </DialogDescription>
          </DialogHeader>
          <div className="grid gap-4 py-4">
            <div className="grid grid-cols-4 items-center gap-4">
              <Input
                id="name"
                defaultValue="Pedro Duarte"
                className="col-span-3"
              />
            </div>
            <div className="grid grid-cols-4 items-center gap-4">
              <Input
                id="username"
                defaultValue="@peduarte"
                className="col-span-3"
              />
            </div>
          </div>
          <DialogFooter>
            <Button variant="ghost">Skip</Button>
            <Button className="bg-primary-accent" onClick={handleVerifyButton}>
              Verify
            </Button>
          </DialogFooter>
        </DialogContent>
      </Dialog>
    </>
  );
};
